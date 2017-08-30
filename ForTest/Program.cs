using System;
using System.Text.RegularExpressions;

namespace ForTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius : ");
            int celsius = int.Parse(Console.ReadLine());
            int farenvalue = faren(celsius);
            Console.WriteLine("Temperature in Fahrenheit is : " + farenvalue);
            Console.ReadLine();
        }

        public static int faren (int celsius)
        {
            int faren;
            faren = (celsius * 9) / 5 + 32;
            return faren;
        }
    }
}