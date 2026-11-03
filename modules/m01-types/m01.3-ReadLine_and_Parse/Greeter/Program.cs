using System;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine("Сколько тебе лет?");
            string ageInput = Console.ReadLine();
            bool validNumber = int.TryParse(ageInput, out int age);
            bool isBetween = validNumber && age >= 0 && age <= 150;
            
            if (isBetween)
            {
                Console.WriteLine($"Тебе {age} лет");
            }

            else
            {
                Console.WriteLine("Неверное значение");
            }

        }
    }
}