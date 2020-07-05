using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    class RegularTriangle : Triangle
    {
        public RegularTriangle(int _a, int _b, int _c) : base(_a, _b, _c)
        {
            //this._a = _a;
            //this._b = _b;
            //this._c = _c;
        }

        // i am not overriding the ivrtual
        // therefor i am getting papa's implementation
        // by default
    }
}
