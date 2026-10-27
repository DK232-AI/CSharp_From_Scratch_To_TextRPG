using System;

namespace First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KaribuDev");
            Console.WriteLine("Moscow");
            Console.WriteLine("I am a game developer and i love to create games");
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();
        }
    }
}