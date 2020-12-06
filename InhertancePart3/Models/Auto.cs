using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertancePart3.Models
{
    public class Auto
    {
        //public const int NumberOfDoors = 4;
       // public readonly int NumberOfDoors;
        public string Type { get; set; }
        public static readonly int NumberOfDoors;

        public Auto(int doors) // 5
        {
            //NumberOfDoors = doors; // numberofdoors = 5
           // NumberOfDoors++;//hire you can do it 
        }

        static Auto()
        {
            NumberOfDoors++;
        }

    }
}
