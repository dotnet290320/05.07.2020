using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    abstract class Triangle
    {
        public double _a, _b, _c;

        protected Triangle(double _a, double _b, double _c)
        {
            this._a = _a;
            this._b = _b;
            this._c = _c;
        }

        public virtual double GetHekef()
        {
            return _a + _b + _c;
        }
    }
}
