using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlLibrary
{
    public class Register
    {
        ushort address;
        string code;
        string name;
        ushort value;
        ushort factoryDefault;
        string defaultVal;
        string unit;
        string max;
        string min;
        bool changeableDuringWork;
        bool readOnly;
        bool availableIn;
        private Register() { }
        public Register(ushort address)
        {
            this.Address = address;
        }
        public ushort Address { get => address; private set => address = value; }
        public string Code { get => code; private set => code = value; }
        public string Name { get => name; private set => name = value; }
        public ushort Value { get => value; set => this.value = value; }
        public ushort FactoryDefault { get => factoryDefault; private set => factoryDefault = value; }
        public string DefaultVal { get => defaultVal; private set => defaultVal = value; }
        public string Unit { get => unit; private set => unit = value; }
        public string Max { get => max; private set => max = value; }
        public string Min { get => min; private set => min = value; }
        public bool ChangeableDuringWork { get => changeableDuringWork; private set => changeableDuringWork = value; }
        public bool AvailableIn { get => availableIn; private set => availableIn = value; }
        public bool ReadOnly { get => readOnly; private set => readOnly = value; }


        public static Register ParseString(string line)
        {
            var arrayParams = line.Split(';');
            Register reg = new Register();
            try
            {
                reg.Address = ushort.Parse(arrayParams[0]);
                reg.Code = arrayParams[1];
                reg.Name = arrayParams[2];
                if (ushort.TryParse(arrayParams[3], out ushort result))
                {
                    reg.Value = result;
                    reg.FactoryDefault = result;
                }               
                reg.DefaultVal = arrayParams[4];
                reg.Unit = arrayParams[5];
                reg.Max = arrayParams[6];
                reg.Min = arrayParams[7];
                reg.ChangeableDuringWork = getBool(arrayParams[8]);
                reg.ReadOnly = getBool(arrayParams[9]);
                reg.AvailableIn = getBool(arrayParams[10]);
            }
            catch (Exception)
            {
                return null;
            }         
            return reg;
        }

        private static bool getBool(string s)
        {
            bool result = false;
            if(s != "")
            {
                ushort temp = ushort.Parse(s);
                if (temp == 1) result = true;
                else result = false;
            }
            return result;
        }

        public bool IsEnable(DriveModel model)
        {
            bool result = false;
            if (AvailableIn)
            {
                result = true;
            }
            return result;
        }
    }
}
