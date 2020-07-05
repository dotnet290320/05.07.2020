using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720_
{
    class Program
    {
        // overloading
        static void Add(int x, int y, int z)
        {
            Console.WriteLine($"{x} +{y} +{z} = {x+y+z}");
        }

        static void Add(int x, int y)
        {
            Console.WriteLine($"{x} +{y} = {x + y }");
        }

        static void Main(string[] args)
        {
            Add(1, 3, 5);
            Add(6, 7);

            Car honda = new Car(_nefah: 2000, _brand: "honda",
                _model: "CX");
            //Car honda = new Car("honda", "CX", 2000);

            //{
            //    _brand = "Honda"
            //};
            Console.WriteLine(honda);

            Car suzuki = new Car("Swift", 1200)
            {
                _brand = "Suzuki"
            };

            Car mitsubishi = new Car();
        }
    }
}
