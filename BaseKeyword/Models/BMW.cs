using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword.Models
{
    public class BMW : Auto
    {
        public new int NumberOfDoors { get; set; } = 5;

        public void Print()
        {
            NumberOfDoors++;
            Console.WriteLine(base.NumberOfDoors);
        }
    }
}
