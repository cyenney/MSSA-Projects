using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //average of arrayA
            double sumA = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                sumA += arrayA[i];
            }
            double average = sumA / arrayA.Length;
            Console.WriteLine("The average value of array a is " + average);

            //average of arrayB
            double sumB = 0;
            for (int i = 0; i < arrayB.Length; i++)
            {
                sumB += arrayB[i];
            }
            double averageB = sumB / arrayB.Length;
            Console.WriteLine("The average value of array b is " + averageB);


            //average of arrayC
            double sumC = 0;
            for (int i = 0; i < arrayC.Length; i++)
            {
                sumC += arrayC[i];
            }
            double averageC = sumC / arrayC.Length;
            Console.WriteLine("The average value of array C is " + averageC);
            Console.ReadLine();


        }
    }
}
