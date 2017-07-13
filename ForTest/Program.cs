using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.startText);
            int celsius = int.Parse(Console.ReadLine());
            int farenvalue = Faren(celsius);
            Console.WriteLine(StringHelper.tempIsFar + farenvalue);
            if (farenvalue >= 64)
            {
                RunForest(StringHelper.runRun);
            }
            else
            {
                StayHomeForest(StringHelper.toCold);
            }
            Console.ReadLine();
        }

        public static int Faren(int celsius)
        {
            int faren;
            faren = (celsius * 9) / 5 + 32;
            return faren;
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
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    
}