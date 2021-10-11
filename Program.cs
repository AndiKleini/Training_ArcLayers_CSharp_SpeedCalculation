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

            var speedCalculation = GetCalculation();
            speedCalculation.ProcessSpeedCalculation(meter, seconds);
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

        private static ISpeedCalculation GetCalculation()
        {
            return new SpeedCalculation(new FileStorage());
        }
    }
}
