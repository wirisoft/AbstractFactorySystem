using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AbstractFactory
{
    public abstract class OperatingSystemFactory
    {
        public abstract IOperatingSystem CreateOperatingSystem();
    }
}