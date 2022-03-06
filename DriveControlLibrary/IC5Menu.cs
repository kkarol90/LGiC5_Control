using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveControlLibrary
{
    internal class IC5Menu
    {
        public IC5Menu(LGdrive drive)
        {
            this.Drive = drive;
        }

        public LGdrive Drive { get; private set; }




    }
}
