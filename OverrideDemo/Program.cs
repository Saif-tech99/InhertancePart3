using OverrideDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Id = 0001;
            child.Name = "Saif0001";
            //child.Print();

            Console.WriteLine(child.ToString());

            Child c1 = new Child();
            c1.Id = 12311;
            c1.Name = "sdsdsd";

            Console.WriteLine(c1.ToString());

            Child c2 = new Child()
            {
                Id = 1234,
                Name = "zsdcv "
            };

            Console.WriteLine(c2.ToString());
        }
    }
}
