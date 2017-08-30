using System;
using System.Collections.Generic;
using System.Text;

namespace ForTest
{
    class Converters
    {
        /// <summary>
        /// Converts from Celsius to Fahrenheit
        /// </summary>
        /// <param name="celsiusValue"></param>
        /// <returns></returns>
        public static double FahrenheitConverter(double celsiusValue)
        {
            return (celsiusValue * 9) / 5 + 32;
        }
        /// <summary>
        /// Converts from Fahrenheit to Celsius
        /// </summary>
        /// <param name="fahrenheitValue"></param>
        /// <returns></returns>
        public static double CelsiusConverter(double fahrenheitValue)
        {
            return 5.0 / 9.0 * (fahrenheitValue - 32);
        }
    }
}
