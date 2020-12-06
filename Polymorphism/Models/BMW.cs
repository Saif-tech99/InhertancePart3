using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class BMW:Auto
    {
        public int Id { get; set; }
        public override string ToString()
        {
            string s = $"{Id} {Name} {Color}";
            return s;
        }
    }
}
