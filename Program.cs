using System;
using System.IO;

namespace SpeedCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the speed calculator.");

            int meter, seconds;
            ReadInput(out meter, out seconds);

            float speed = GetSpeed(meter, seconds);

            // persist calculation
            Store(meter, seconds, speed);
        }

        private static void Store(int meter, int seconds, float speed)
        {
            String text = "Speed was calculated from distance-> " + meter + " m and time " + seconds + " secs " + "as " + speed;
            File.WriteAllText("./output.txt", text);
        }

        private static void ReadInput(out int meter, out int seconds)
        {
            Console.WriteLine("Please enter the distance in meters.");
            while (!int.TryParse(Console.ReadLine(), out meter))
            {
                Console.WriteLine("Invalid input ... must be a number.");
            }

            Console.WriteLine("Please enter the time in seconds.");
            while (!int.TryParse(Console.ReadLine(), out seconds))
            {
                Console.WriteLine("Invalid input ... must be a number.");
            }
        }

        private static float GetSpeed(int meter, int seconds)
        {
            return (float)meter / (float)seconds;
        }
    }
}
