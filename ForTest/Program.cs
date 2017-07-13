using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.translateFromCelcuisToFahrenheitPress1);
            Console.WriteLine(StringHelper.translateFromFahrenheitToCelcuisPress2);
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine(StringHelper.enterTheTemperatureInCelsius);
                int celsius = int.Parse(Console.ReadLine());
                double farenValue = ConvertFahrenheit(celsius);
                Console.WriteLine(StringHelper.temperatureInFahrenheitIs + farenValue);
                if (farenValue >= 64)
                {
                    RunForest(StringHelper.runRun);
                }
                else
                {
                    StayHomeForest(StringHelper.toCold);
                }
                Console.ReadLine();
            }
            else if (input == 2)
            {
                // convert to Celcuis
                Console.WriteLine(StringHelper.enterTheTemperatureInFahrenheit);
                int fahrenheit = int.Parse(Console.ReadLine());
                double celsiusValue = ConvertCelsius(fahrenheit);
                Console.WriteLine(StringHelper.temperatureInCelsiusIs + celsiusValue);
                if (celsiusValue >= 18)
                {
                    RunForest(StringHelper.runRun);
                }
                else
                {
                    StayHomeForest(StringHelper.toCold);
                }
                Console.ReadLine();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(StringHelper.notAValidNumber);
                Console.ReadLine();
            }
        }

        public static double ConvertFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }
        public static double ConvertCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        static void RunForest(string text)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void StayHomeForest(string text)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}