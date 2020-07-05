using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    class TwoSidesEqualTriangle : Triangle
    {

        public TwoSidesEqualTriangle(int _ab, int _c) : base(_ab, _ab, _c)
        {
            //this._a = _ab;
            //this._b = _ab;
            //this._c = _c;
        }

        public override double GetHekef()
        {
            return this._a * 2 + this._c;
        }
    }
}