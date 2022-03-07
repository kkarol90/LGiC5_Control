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
        public string MasterMssg { get; set; }
        public bool ReadCorrectly { get; set; }
    }
    public class DriveLibMaster
    {
        private static object locker;
        private IModbusSerialMaster master;
        private byte slaveAddr;
        private SerialPort port;
        private static DriveLibMaster instance;
        private int readTimeout;
        private int writeTimeout;
        public event EventHandler CommonAreaRead;

        private DriveLibMaster() 
        {
            locker = new object();
            readTimeout = 200;
            writeTimeout = 200;
        }

        private void OnCommonAreaRead(EventArgs arg)
        {
            CommonAreaRead?.Invoke(this, arg);
        }

        public static DriveLibMaster GetMaster()
        {
            if (instance == null) instance = new DriveLibMaster();
            return instance;
        }

        public void SetParameters(SerialPort port, byte slave)
        {
            this.port = port;
            this.slaveAddr = slave;
            master = ModbusSerialMaster.CreateRtu(port);
            master.Transport.ReadTimeout = readTimeout;
            master.Transport.WriteTimeout = writeTimeout;
        }
        public bool SendData(List<List<Register>> regGroups)
        {
            return ConnectionProvider(() =>
            {
                foreach (var gr in regGroups)
                {
                    master.WriteMultipleRegisters(slaveAddr, (ushort)(gr.First().Address - 1)
                        , gr.Select(x => x.Value).ToArray());
                }
            });
        }

        public bool ReadData(List<List<Register>> regGroups)
        {
            if (regGroups == null)  return false;
            return ConnectionProvider(() =>
            {
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
            });
        }

        public bool SendSingleRegister(ushort addr, ushort value)
        {
            return ConnectionProvider(() =>
            {
                master.WriteSingleRegister(slaveAddr, (ushort)(addr - 1), value);
            });
        }
        private bool ConnectionProvider(Action action)
        {
            ModbusEventArgs mea = new ModbusEventArgs();
            bool isReadCorrect = false;
            try
            {
                lock (locker)
                {
                    port.Open();
                    action();
                    port.Close();                    
                }
                mea.ReadCorrectly = true;
                isReadCorrect = true;
            }
            catch (System.IO.IOException)
            {
                mea.ReadCorrectly = false;
                mea.MasterMssg = "Serial portconnection problem.\nCheck RS485 interface connection.";
            }
            catch (Exception)
            {
                mea.ReadCorrectly = false;
                mea.MasterMssg = "Modbus communication fail.\ncommunication timed out";
            }
            DriveLibMaster.GetMaster().OnCommonAreaRead(mea);
            return isReadCorrect;
        }
    }
}
