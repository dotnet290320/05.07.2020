using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("My greate calc requires 2 arguments!!!");
                return;
            }

            Console.WriteLine("Your arguments:");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{i+1}:{args[i]}");
            }

            //Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(args[0]);

            //Console.WriteLine("Enter a number:");
            int b = Convert.ToInt32(args[1]);

            Console.WriteLine($"{a} + {b} = {(a+b)}");

            //Console.ReadLine();
        }
    }
}
