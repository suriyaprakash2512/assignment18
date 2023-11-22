using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartphone = new SmartPhone("Moto");
            smartphone.connect();
            smartphone.charge(55);
            Console.WriteLine(smartphone.Display());


            Console.WriteLine();

            Laptop laptop = new Laptop("Dell");
            laptop.connect();
            laptop.charge(40);
            Console.WriteLine(laptop.Display());


            Console.ReadKey();

        }
    }
}
