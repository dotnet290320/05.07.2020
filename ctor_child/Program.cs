using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctor_child
{
    class Person
    {
        public string _name;

        public Person(string _name)
        {
            this._name = _name;
        }

        public override string ToString()
        {
            return $"[{base.ToString()}] {_name}";
        }
    }

    class Employee : Person
    {
        public int _salary;

        public Employee() : base(null)
        {

        }

        // ctor signature : ctor papa -- for default: base()
        public Employee(string _name, int _salary) : base(_name)
        {
            // this line will be invoked at papa
            //this._name = _name;

            this._salary = _salary;
        }

        // ctor signature : ctor papa -- for default: base()
        public Employee(string _name) : base(_name)
        {
            // this line will be invoked at papa
            //this._name = _name;

            //this._salary = _salary;
        }

        // ctor signature : ctor papa -- for default: base()
        public Employee(int _salary) : base("john doe")
        {
            // this line will be invoked at papa
            //this._name = _name;

            this._salary = _salary;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee d = new Employee("ran", 30_000);
            Console.WriteLine(d._name);
            Console.WriteLine(d._salary);
        }
    }
}
