using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetToInches
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of feet to be converted to inches.");
            string inputValueA = Console.ReadLine();

            double feetToinches = double.Parse(inputValueA);

            double totalInches = feetToinches * 12;

            Console.WriteLine(inputValueA + " feet to inches is " + totalInches);
            Console.ReadLine();

        }
    }
}
