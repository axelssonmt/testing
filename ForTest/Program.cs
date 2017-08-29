using System;
using System.Text.RegularExpressions;

namespace ForTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.convertFromCelsiusToFahrenheitPress1);
            Console.WriteLine(StringHelper.convertFromFahrenheitToCelsiusPress2);
            var line = Console.ReadLine();
            int value;

            if(int.TryParse(line, out value))
            {
                if (value == 1)
                {
                    Console.WriteLine(StringHelper.enterTheTemperatureInCelsius);
                    double celsiusValue = int.Parse(Console.ReadLine());
                    double fahrenheitValue = Converters.FahrenheitConverter(celsiusValue);
                    Console.WriteLine(StringHelper.temperatureInFahrenheitIs + fahrenheitValue);
                    Console.ReadLine();

                }
                else if (value == 2)
                {
                    Console.WriteLine(StringHelper.enterTheTemperatureInFahrenheit);
                    double fahrenheitValue = int.Parse(Console.ReadLine());
                    double celsiusValue = Converters.CelsiusConverter(fahrenheitValue);
                    Console.WriteLine(StringHelper.temperatureInCelsiusIs + celsiusValue);
                    Console.ReadLine();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(StringHelper.NotAValidEntry);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You need to enter a number (1 and 2 to convert)");
            }
        }
    }
}