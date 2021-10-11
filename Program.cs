using System;
using System.IO;

namespace SpeedCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the speed calculator.");

            Console.WriteLine("Please enter the distance in meters.");
            int meter;
            while (!int.TryParse(Console.ReadLine(), out meter))
            {
                Console.WriteLine("Invalid input ... must be a number.");
            }

            Console.WriteLine("Please enter the time in seconds.");
            int seconds;
            while (!int.TryParse(Console.ReadLine(), out seconds))
            {
                Console.WriteLine("Invalid input ... must be a number.");
            }

            // perform calculation
            float speed = (float)meter / (float)seconds;

            // persist calculation
            String text = "Speed was calculated from distance-> " + meter + " m and time " + seconds + " secs " + "as " + speed;
            File.WriteAllText("./output.txt", text);
        }
    }
}
