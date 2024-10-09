using System;
using System.Diagnostics;
namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vänligen skriv in ditt favorit bok");
            string favoritbok = Console.ReadLine();

            Console.WriteLine("din favorit bok är" + " " + favoritbok);

            Console.ReadKey();
        }
    }
}

