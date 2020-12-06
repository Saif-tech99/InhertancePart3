using Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos = new Auto[3];
            int[] array = new int[3];
            array[0] = 9;
            array[1] = 255;
            array[2] = 22;

            Auto auto = new Auto();
            auto.Name = "Parent";
            auto.Color = "white";

            Auto auto1 = new BMW();//impliciet casting
            auto1.Color = "red";
            auto1.Name = "bmw";
            //BMW bmwtemp = (BMW)auto1;//expliciet casting
            BMW bmwtemp = auto1 as BMW;//expliciet casting
            if (bmwtemp is BMW && bmwtemp != null)
            {
                bmwtemp.Id = 987;
            }

            Audi audi = new Audi
            {
                Color = "black",
                Id = 123,
                Name = "C8"
            };

            autos[0] = auto;
            autos[1] = bmwtemp;
            autos[2] = audi;
            foreach (var item in autos)
            {
                Console.WriteLine(item);
                Print(item);
            }

            Console.WriteLine(bmwtemp.Id);
            Console.WriteLine(bmwtemp.Name);
            Console.WriteLine(bmwtemp.Color);

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine();
            Print(auto);
            Print(bmwtemp);
            Print(audi);
        }

        public static void Print(Auto auto)
        {
            Console.WriteLine("**************** print method ****************");
            if (auto is Auto)
            {
                Console.WriteLine(auto.Color);
                Console.WriteLine(auto.Name);
            }
            if (auto is BMW)
            {
                BMW bMW = auto as BMW; // the same as the lin of the audi ounder
                Console.WriteLine($"{bMW.Id}\t{bMW.Name}\t{bMW.Color}");
                //Console.WriteLine(bMW.Name);
                //Console.WriteLine(bMW.Color);
            }
            if (auto is Audi)
            {
                Audi audi = (Audi)auto;//here it was from above
                Console.Write(audi.Id);
                Console.WriteLine();
                Console.Write(audi.Name);
                Console.WriteLine();
                Console.Write(audi.Color);
                Console.WriteLine();
            }

        }
    }
}
