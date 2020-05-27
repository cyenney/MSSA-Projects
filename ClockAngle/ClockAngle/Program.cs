using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class Program
    {
        public int hours = 0;
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter the time as an integer to find the angle of the hour and minute hands.");
            string userInput = Console.ReadLine();
            int time = int.Parse(userInput);

            int hours = time / 100;
            double minutes = time % 100;


            double minuteAngle = minutes * 6;
            double hourRemainder = .5 * minutes;
            double hourAngle = hours * 30 + hourRemainder;
            if (hourAngle > 360)
                hourAngle -= 360;

            Console.WriteLine("The hour hand is at an angle of " + hourAngle);
            Console.WriteLine("The minute hand is at an angle of " + minuteAngle);
            Console.ReadLine();

        }
    }
}
