using System;
using System.Collections.Generic;
namespace PropertyTest
{
    class Program
    {
        static void Main(string[] args)
        {
           House house = new House("Akure",false,21, 0.01M);
           House house1 = new House("Osun",false,23, 0.72M);
           House house2 = new House("Lagos",false,31, 0.14M);
           Bus bus = new Bus(45,3456, 3500M);
           Bus bus1 = new Bus(35,3434, 3111M);
           Bus bus2= new Bus(75,1777, 5300M);
            List<ITaxable> taxables = new List<ITaxable>(){house, house1, house2, bus, bus1, bus2};
              Console.WriteLine("\nAll Taxables Processed Polymorphically\n");
            foreach (ITaxable taxable in taxables)
            {
              Console.Writeline(taxable);
                }
            }
        }
    }
}





