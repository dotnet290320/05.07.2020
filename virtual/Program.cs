using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_virtual
{
    class Program
    {
        static void PrintTriangleHekef(Triangle t)
        {
            Console.WriteLine(t.GetHekef());
        }

        static void Main(string[] args)
        {
            RegularTriangle t1 = new RegularTriangle(4, 7, 10);
            Console.WriteLine(t1.GetHekef());

            TwoSidesEqualTriangle t2 = new TwoSidesEqualTriangle()
            {
                _a = 8,
                _b = 8,
                _c = 12
            };
            Console.WriteLine(t2.GetHekef());

            EqualSidesTriangle t3 = new EqualSidesTriangle(10);
            Console.WriteLine(t3.GetHekef());

            PrintTriangleHekef(t3);
        }
    }
}
