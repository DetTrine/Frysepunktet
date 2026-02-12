using System.ComponentModel.Design;

namespace Frysepunktet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What might the temp be");
            float temp = float.Parse(Console.ReadLine());

            if (temp == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ideal but keep an eye out");
            }
            else if (temp < 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Fucking freezing, damn, but that's good");
            }
            else if (temp > 1)
            { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Temperature too hot like u boo");
            }
            Console.ResetColor ();

        }
    }
}
   