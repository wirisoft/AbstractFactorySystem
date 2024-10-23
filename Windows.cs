using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   

namespace _03AbstractFactory
{
    public class Windows: IOperatingSystem
    {
        public string Name => "Windows";
    }
}