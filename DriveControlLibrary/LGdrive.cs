using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlLibrary
{
    public enum DriveModel { SV_iS3=0, SV_iG=1, SV_iV=2, SV_iH=3, SV_iS5=4, SV_iV5=5, SV_iG5=7, SV_iC5=8, SV_iP5=9, SV_iGA=10}
    public class LGdrive
    {
        public LGdrive()
        {            
            this.Memory = new ModbusMemory(DriveModel.SV_iC5);
        }
        
        public ModbusMemory Memory { get; private set; }

    }
}
