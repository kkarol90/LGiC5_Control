using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace DriveControlLibrary
{
    public class ModbusEventArgs : EventArgs
    {
        public string MasterMsg { get; set; }
        public bool ReadCorrectly { get; set; }
    }
    public class ModbusProvider
    {
        private static object locker;
        private IModbusSerialMaster master;
        private byte slaveAddr;
        private SerialPort port;
        private static ModbusProvider instance;
        public event EventHandler DataTransferred;

        private ModbusProvider() 
        {
            locker = new object();
        }

        private void OnDataTransfer(EventArgs arg)
        {
            DataTransferred?.Invoke(this, arg);
        }
        public static ModbusProvider GetMaster()
        {
            if (instance == null) instance = new ModbusProvider();
            return instance;
        }
        public void SetParameters(SerialPort port, byte slaveAddr)
        {
            this.port = port;
            this.slaveAddr = slaveAddr;
            master = ModbusSerialMaster.CreateRtu(port);
        }
        public void SetTimeout(int readTimeout, int writeTimeout)
        {
            if (master == null) return;
            master.Transport.ReadTimeout = readTimeout;
            master.Transport.WriteTimeout = writeTimeout;
        }
        public bool SendData(List<List<Register>> regGroups)
        {
            if (regGroups == null) return false;
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
                port.Close();
                mea.ReadCorrectly = false;
                mea.MasterMsg = "Serial portconnection problem.\nCheck RS485 interface connection.";
            }
            catch (Exception)
            {
                port.Close();
                mea.ReadCorrectly = false;
                mea.MasterMsg = "Modbus communication fail.\ncommunication timed out";
            }
            ModbusProvider.GetMaster().OnDataTransfer(mea);
            return isReadCorrect;
        }
    }
}
