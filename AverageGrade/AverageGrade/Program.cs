using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input 10 numbers to find the average letter grade");
            string inputValue1 = Console.ReadLine();
            Console.WriteLine("input 9 more numbers to find the average");
            string inputValue2 = Console.ReadLine();
            Console.WriteLine("input 8 more numbers to find the average");
            string inputValue3 = Console.ReadLine();
            Console.WriteLine("Input 7 more numbers to find the average");
            string inputValue4 = Console.ReadLine();
            Console.WriteLine("input 6 more numbers to find the average");
            string inputValue5 = Console.ReadLine();
            Console.WriteLine("input 5 more numbers to find the average");
            string inputValue6 = Console.ReadLine();
            Console.WriteLine("Input 4 more numbers to find the average");
            string inputValue7 = Console.ReadLine();
            Console.WriteLine("input 3 more numbers to find the average");
            string inputValue8 = Console.ReadLine();
            Console.WriteLine("Input 2 more numbers to find the average");
            string inputValue9 = Console.ReadLine();
            Console.WriteLine("input 1 more numbers to find the average");
            string inputValue10 = Console.ReadLine();

            double Value1 = double.Parse(inputValue1);
            double Value2 = double.Parse(inputValue2);
            double Value3 = double.Parse(inputValue3);
            double Value4 = double.Parse(inputValue4);
            double Value5 = double.Parse(inputValue5);
            double Value6 = double.Parse(inputValue6);
            double Value7 = double.Parse(inputValue7);
            double Value8 = double.Parse(inputValue8);
            double Value9 = double.Parse(inputValue9);
            double Value10 = double.Parse(inputValue10);

            double sum = Value1 + Value2 + Value3 + Value4 + Value5 + Value6 + Value7 + Value8 + Value9 + Value10;
            double average = sum / 10;
            Console.WriteLine();

            if (average >= 90)
                Console.WriteLine('A');
            else if (average >= 80)
                Console.WriteLine('B');
            else if (average >= 70)
                Console.WriteLine('C');
            else if (average >= 60)
                Console.WriteLine('D');
            else if (average <= 59)
                Console.WriteLine('F');


            Console.WriteLine();
            Console.WriteLine(" the average = " + average);
            Console.ReadLine();

        }
    }
}
