using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius : ");
            int celsius = int.Parse(Console.ReadLine());
            int farenvalue = Faren(celsius);
            Console.WriteLine("Temperature in Fahrenheit is : " + farenvalue);
            RunForest("Running running!");
            Console.ReadLine();
        }

        public static int Faren (int celsius)
        {
            int faren;
            faren = (celsius * 9) / 5 + 32;
            return faren;
        }

        static void RunForest(string run)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine(run);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}