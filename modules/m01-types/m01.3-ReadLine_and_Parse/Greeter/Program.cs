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
            string age_s = Console.ReadLine();
            bool validNumber = int.TryParse(age_s, out int age_i);
            bool isBetween = validNumber && age_i >= 0 && age_i <= 150;
            
            if (isBetween)
            {
                Console.WriteLine($"Тебе {age_i} лет");
            }

            else
            {
                Console.WriteLine("Неверное значение");
            }

        }
    }
}