using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlLibrary
{
    public class ModbusEventArgs : EventArgs
    {
        public string CommonAreaReadMsg { get; set; }
        public bool CommonAreaReadCorrectly { get; set; }
    }
    public class DriveLibMaster
    {
        private static object locker = new object();
        private LGdrive drive;
        private IModbusSerialMaster master;
        private byte slaveAddr;
        private SerialPort port;
        private static DriveLibMaster instance;
        private int readTimeout = 200;
        private int writeTimeout = 200;
        public event EventHandler CommonAreaRead;

        private DriveLibMaster() { }

        private void OnCommonAreaRead(EventArgs arg)
        {
            CommonAreaRead?.Invoke(this, arg);
        }
        public static DriveLibMaster GetMaster()
        {
            if (instance == null) instance = new DriveLibMaster();
            return instance;
        }
        public void SetParameters(SerialPort port, byte slave, LGdrive drive)
        {
            this.port = port;
            this.slaveAddr = slave;
            master = ModbusSerialMaster.CreateRtu(port);
            master.Transport.ReadTimeout = readTimeout;
            master.Transport.WriteTimeout = writeTimeout;
            this.drive = drive;
        }
        public void SendData(List<Register> regList)
        {
            List<List<Register>> regGroups = drive.Memory.GroupedRegistersToDataExchange(regList, 8);
            lock (locker)
            {
                port.Open();
                foreach (var gr in regGroups)
                {
                    master.WriteMultipleRegisters(slaveAddr,(ushort)(gr.First().Address-1)
                        , gr.Select(x => x.Value).ToArray());
                }
                port.Close();
            }
        }
        public void ReadData(List<Register> regList)
        {
            List<List<Register>> regGroups = drive.Memory.GroupedRegistersToDataExchange(regList, 8);
            lock (locker)
            {
                port.Open();
                foreach (var gr in regGroups)
                {
                    ushort[] tempArray = new ushort[gr.Count];
                    ushort startFrom = (ushort)(gr.First().Address - 1);
                    ushort length = (ushort)gr.Count;
                    master.ReadHoldingRegisters(slaveAddr, startFrom, length).CopyTo(tempArray, 0);
                    for (int i = 0; i < gr.Count; i++)
                    {
                        gr[i].Value = tempArray[i];
                    }
                }
                port.Close();
            }
        }
        public bool ReadCommonArea()
        {
            ModbusEventArgs mea = new ModbusEventArgs();
            bool isReadCorrect = false;
            try
            {
                List<ushort> holdingRegistersValue = new List<ushort>();
                List<List<Register>> l = drive.Memory.GetCommonAreaToDataExchange();
                lock (locker)
                {                  
                    port.Open();
                    foreach (var data in drive.Memory.GetCommonAreaToDataExchange())
                    {
                        holdingRegistersValue.AddRange(master.ReadHoldingRegisters(slaveAddr
                            , (ushort)(data.First().Address - 1), (ushort)data.Count));
                    }
                    port.Close();
                    for (int i = 0; i < drive.Memory.CommonArea.Count - 1; i++)
                    {
                        drive.Memory.CommonArea[i + 1].Value = holdingRegistersValue[i];
                    }
                }
                mea.CommonAreaReadMsg = "Common area read correctly.";
                mea.CommonAreaReadCorrectly = true;
                isReadCorrect = true;
            }
            catch (System.IO.IOException)
            {
                mea.CommonAreaReadCorrectly = false;
                mea.CommonAreaReadMsg = "Serial portconnection problem.\nCheck RS485 interface connection.";
            }
            catch (Exception)
            {
                mea.CommonAreaReadCorrectly = false;
                mea.CommonAreaReadMsg = "Modbus communication fail.\ncommunication timed out";
            }
                DriveLibMaster.GetMaster().OnCommonAreaRead(mea);
                return isReadCorrect;        
        }

        public void SendSingleRegister(ushort addr, ushort value)
        {
            lock (locker)
            {
                port.Open();
                master.WriteSingleRegister(slaveAddr, (ushort)(addr-1), value);
                port.Close();
            }
        }
    }
}
