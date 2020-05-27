using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseArray
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
           Print the reverse of all three arrays.*/
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //ArrayA reversed
            for (int i = 0; i < arrayA.Length / 2; i++)
            {
                int tmp = arrayA[i];
                arrayA[i] = arrayA[arrayA.Length - i - 1];
                arrayA[arrayA.Length - i - 1] = tmp;
            }
            Console.WriteLine("ArrayA reversed : " + string.Join(",", arrayA));


            //ArrayB reversed
            for (int i = 0; i < arrayB.Length / 2; i++)
            {
                int tmp = arrayB[i];
                arrayB[i] = arrayB[arrayB.Length - i - 1];
                arrayB[arrayB.Length - i - 1] = tmp;
            }
            Console.WriteLine("ArrayB reversed : " + string.Join(",", arrayB));

            //ArrayC reversed
            for (int i = 0; i < arrayC.Length / 2; i++)
            {
                int tmp = arrayC[i];
                arrayC[i] = arrayC[arrayC.Length - i - 1];
                arrayC[arrayC.Length - i - 1] = tmp;
            }
            Console.WriteLine("ArrayC reversed : " + string.Join(",", arrayC));
            Console.ReadLine();

        }
    }
}
