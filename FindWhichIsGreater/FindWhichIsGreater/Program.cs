using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWhichIsGreater
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter 2 values to find which is greater. one at a time");
            string inputValue1 = Console.ReadLine();
            Console.WriteLine("please enter the second value.");
            string inputValue2 = Console.ReadLine();

            double firstValue = double.Parse(inputValue1);
            double secondValue = double.Parse(inputValue2);

            if (firstValue > secondValue)
            {
                Console.WriteLine(inputValue1 + " is greater than " + inputValue2);
            }

            else if (firstValue < secondValue)
            {
                Console.WriteLine(inputValue2 + " is greater than " + inputValue1);
            }

            Console.ReadLine();

        }
    }
}
