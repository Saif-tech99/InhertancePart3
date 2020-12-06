using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideDemo.Models
{
    public class Parent
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public virtual void Print()//Polymorphism
        {
            Console.WriteLine(Name);
            Console.WriteLine(Id);
        }

        public override string ToString()
        {
            string s = "hello from parent";
            return s;
        }
    }
}
