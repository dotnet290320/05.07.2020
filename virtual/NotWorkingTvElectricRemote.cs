using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    class NotWorkingTvElectricRemote : NotWorkingTvDevice
    {
        public override void TurnOn()
        {
            Console.WriteLine("bzzz bzzz...");
        }
    }
}
