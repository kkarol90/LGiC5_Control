using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlLibrary
{
    public class ModbusMemory
    {

        public List<Register> GroupDRV { get; set; }
        public List<Register> GroupF { get; set; }
        public List<Register> GroupH { get; set; }
        public List<Register> GroupI { get; set; }
        public List<Register> CommonArea { get; set; }
        public List<Register> AllParams
        {
            get
            {
                List<Register> l = new List<Register>();
                l.AddRange(GroupDRV);
                l.AddRange(GroupF);
                l.AddRange(GroupH);
                l.AddRange(GroupI);
                return l;
            }
        }
        //public CommonArea CommonArea { get; set; }

        public ModbusMemory(DriveModel model)
        {
            // this.CommonArea = new CommonArea();
            CommonArea = new List<Register>();
            GroupDRV = new List<Register>();
            GroupF = new List<Register>();
            GroupH = new List<Register>();
            GroupI = new List<Register>();
            generateMemory(model);
        }
        private void generateMemory(DriveModel model)
        {
            getActiveRegisters("ParametersCSV/DRV.csv", GroupDRV);
            getActiveRegisters("ParametersCSV/FU1.csv", GroupF);
            getActiveRegisters("ParametersCSV/FU2.csv", GroupH);
            getActiveRegisters("ParametersCSV/I_O.csv", GroupI);
            getActiveRegisters("ParametersCSV/CommonArea.csv", CommonArea);
        }

        private List<Register> getActiveRegisters(string path, List<Register> group)
        {
            List<Register> registers = loadParametersFromCSV(path);
            foreach (var reg in registers)
            {
                if (reg.AvailableIn) group.Add(reg);
            }
            return registers;
        }

        private static List<Register> loadParametersFromCSV(string path)
        {
            return File.ReadAllLines(path)
                       .Skip(1)
                       .Where(line => line.Length > 1)
                       .Select(line => Register.ParseString(line)).ToList();
        }
        public static List<List<Register>> GroupedRegistersToDataExchange(List<Register> groupOfReg, int maxRegPerGroup)
        {
            List<List<Register>> resultGroups = new List<List<Register>>();
            ushort lastRegAddr = (ushort)(groupOfReg.First().Address - 1);
            List<Register> actualList = new List<Register>();
            foreach (var reg in groupOfReg/*.Where(r=>r.AvailableIn == true)*/)
            {
                if ((reg.Address == lastRegAddr + 1) && (actualList.Count < maxRegPerGroup))
                {
                    actualList.Add(reg);
                }
                else
                {
                    resultGroups.Add(actualList);
                    actualList = new List<Register>();
                    actualList.Add(reg);
                }
                lastRegAddr = reg.Address;
            }
            resultGroups.Add(actualList);
            return resultGroups;
        }
        public List<List<Register>> GroupedAllParamsToDataExchange(int maxRegPerGroup)
        {
            List<Register> list = new List<Register>();
            list.AddRange(GroupDRV);
            list.AddRange(GroupF);
            list.AddRange(GroupH);
            list.AddRange(GroupI);

            return GroupedRegistersToDataExchange(list, maxRegPerGroup);
        }

        public List<List<Register>> GetCommonAreaToDataExchange()
        {
            return GroupedRegistersToDataExchange(CommonArea.GetRange(1, CommonArea.Count - 1), 8);
        }

    }
}
