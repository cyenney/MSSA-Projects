using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fizzArray = new int [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};

            for (int i = 0; i < fizzArray.Length; i++)
            {
                if (fizzArray[i] % 3 == 0 && fizzArray[i] % 5 == 0)
                {
                    Console.WriteLine(" Fizz and Buzz");
                }

                else if (fizzArray[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fizzArray[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
              
                else
                {
                    Console.WriteLine(fizzArray[i]);

                }
            }
            Console.ReadLine();

            
        }
    }
}
