using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.convertFromCelsiusToFahrenheitPress1);
            Console.WriteLine(StringHelper.convertFromFahrenheitToCelsiusPress2);
            int input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                Console.WriteLine(StringHelper.enterTheTemperatureInCelsius);
                double celsiusValue = int.Parse(Console.ReadLine());
                double fahrenheitValue = Converters.FahrenheitConverter(celsiusValue);
                Console.WriteLine(StringHelper.temperatureInFahrenheitIs + fahrenheitValue);
                Console.ReadLine();

            }
            else if(input == 2)
            {
                Console.WriteLine(StringHelper.enterTheTemperatureInFahrenheit);
                double fahrenheitValue = int.Parse(Console.ReadLine());
                double celsiusValue = Converters.CelsiusConverter(fahrenheitValue);
                Console.WriteLine(StringHelper.temperatureInCelsiusIs + celsiusValue);
                Console.ReadLine();
            }    
        }
    }
}