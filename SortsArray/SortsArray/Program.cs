using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //not working yet

            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int temp = 0;
            for (int i = 0; i < arrayC.Length - 1; i++)
                for (int j = i + 1; j < arrayC.Length; j++)
                    if (arrayC[i] < arrayC[j])
                    {
                        temp = arrayC[i];
                        arrayC[i] = arrayC[j];
                        arrayC[j] = temp;
                    }
            foreach (int element in arrayC)
                Console.Write(element + " ,");
            Console.ReadLine();

            //prints backwards 

        }
    }
}
