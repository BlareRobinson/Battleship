using System;
using System.Threading;
namespace Battleship
{
    class Program
    {

        static void Calculate()
        {
            var number = 8;
            Console.WriteLine(number + 3);

            number = 20;
            Console.WriteLine(number - 8);
        }

        static void Sleep()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Done sleeping!");

            Calculate();
        }

        static void Main(string[] args)
        {
            
            var greeting = "Welcome to Battleship";
            Console.WriteLine(greeting);

            Calculate();
            Sleep();

        }
    }
}
