using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SmartPhone smartphone = new SmartPhone("Apple", "iPhone 12");
            Laptop laptop = new Laptop("Dell", "XPS 13");


            smartphone.Brand = "Apple";
            smartphone.Model = "iPhone 12";
            laptop.Brand = "Dell";
            laptop.Model = "XPS 13";


            smartphone.Connect();
            smartphone.Recharge(60);
            laptop.Connect();
            laptop.Recharge(120);

            Console.WriteLine(smartphone.Display());
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}