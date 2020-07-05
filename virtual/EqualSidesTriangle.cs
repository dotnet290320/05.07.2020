using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    class EqualSidesTriangle : TwoSidesEqualTriangle
    {
        public EqualSidesTriangle(int a) : base(a, a)
        {
            //this._a = _abc;
            //this._b = _abc;
            //this._c = _abc;
        }

        public override double GetHekef()
        {
            return this._a * 3;
        }

    }
}