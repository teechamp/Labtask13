using System;
using System.Collections.Generic;
namespace PropertyTest
{
    class Program
    {
        static void Main(string[] args)
        {
           House house = new House("lagos",false,21, 0.05M);
           House house1 = new House("Aba",false,23, 0.15M);
           House house2 = new House("Jos",false,31, 0.25M);
           Bus bus = new Bus(30,3455, 3000M);
           Bus bus1 = new Bus(31,3435, 3400M);
           Bus bus2= new Bus(40,1455, 4000M);
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





