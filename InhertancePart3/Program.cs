using InhertancePart3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertancePart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(5);
            auto.Type = "Sedan";
            Console.WriteLine(auto.Type);
            
            Console.WriteLine(auto.NumberOfDoors);
        }
    }
}
