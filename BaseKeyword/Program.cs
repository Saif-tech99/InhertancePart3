using System;
using BaseKeyword.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //BMW bmw = new BMW();
            //bmw.Type = "Sedan";

            //Console.WriteLine(bmw.Type);
            //Console.WriteLine(bmw.NumberOfDoors);

            //bmw.Print();

            Bill bill = new Bill();
            bill.Item = "Book";
            bill.NumberOfItem = 1;
            bill.Prize = 25.00;
            bill.Tax = 6;

            bill.CalculateBill();
            bill.CalculateBillBase();
        }
    }
}
