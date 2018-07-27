using System;
using MokaPot.Backend.Core.Features;
using MokaPot.Frontend.Common;

namespace MokaPot.Frontend.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key = default(ConsoleKey);
            while (key != ConsoleKey.Escape)
            {
                Console.WriteLine("Coffe machine manager:");
                Console.WriteLine("1 - Clean machine");

                key = Console.ReadKey().Key;
                if (key == ConsoleKey.NumPad1 || key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cleaning machine");

                    ICleaningFeature cleaningFeature = new CleaningFeature();
                    var isSuccessful = cleaningFeature.Execute();

                    string message = "Cleaning failed!";
                    if (isSuccessful)
                    {
                        message = "Cleaning complete!";
                    }

                    Console.WriteLine(message);
                }
            }
        }
    }
}
