using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword.Models
{
    public class Bill : Calculate
    {
        public new double Tax { get; set; } = .6;//this way

        public void CalculateBill()
        {
            double calc = (NumberOfItem * Prize) * Tax;
            Console.WriteLine(Item);
            Console.WriteLine(calc);
        }

        public void CalculateBillBase()
        {
            double calc = (NumberOfItem * Prize) * base.Tax / 100;//and tihs way
            Console.WriteLine(Item);
            Console.WriteLine(calc);
        }


    }



}
