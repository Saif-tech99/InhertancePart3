using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo.Models
{
    public class Child : Parent
    {
        public override void Print()//Polymorphism
        {
            Console.WriteLine("Ik ben van child object opgeroepen");
        }

        public override string ToString()
        {
            string s = $" this is the name {Name} and this is the is {Id}";//s = Id + " " + Name; 
            return s;
        }
    }
}
