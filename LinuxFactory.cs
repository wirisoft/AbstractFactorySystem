using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractFactory
{
    public class LinuxFactory : OperatingSystemFactory
    {
        public override IOperatingSystem CreateOperatingSystem()
        {
            return new Linux();
        }
    }
}