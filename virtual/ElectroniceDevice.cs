using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    abstract class ElectroniceDeviceBase
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Device is on!");
        }
    }
}
