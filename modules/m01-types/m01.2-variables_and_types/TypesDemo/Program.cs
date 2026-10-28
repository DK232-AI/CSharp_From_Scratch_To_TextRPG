using System;

namespace TypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "John Brown";
            int age = 49;
            float height = 1.8f;
            bool isStudent = false;
            const char firstNameLetter = 'J';

            Console.WriteLine($"Имя сотрудника: {name}"); // Выведет "Имя сотрудника: John Brown"
            Console.WriteLine($"Возраст сотрудника: {age}"); // Выведет "Возраст сотрудника: 49"
            Console.WriteLine($"Рост сотрудника: {height}"); // Выведет "Рост сотрудника: 1,8"
            Console.WriteLine($"Студент ли сотрудник: {isStudent}"); // Выведет "Студент ли сотрудник: False"
            Console.WriteLine($"Первая буква имени сотрудника: {firstNameLetter}"); // Выведет "Первая буква имени сотрудника: J"
            Console.WriteLine($"Тип переменной name: {name.GetType().Name}"); // Выведет "Тип переменной name: String"
            Console.WriteLine($"Тип переменной age: {age.GetType()}"); // Выведет "Тип переменной age: System.Int32"
            Console.WriteLine($"Тип переменной height: {height.GetType()}"); // Выведет "Тип переменной height: System.Float"
            Console.WriteLine($"Тип переменной isStudent: {isStudent.GetType()}"); // Выведет "Тип переменной isStudent: System.Boolean"
            Console.WriteLine($"Тип переменной firstNameLetter: {firstNameLetter.GetType()}"); // Выведет "Тип переменной firstNameLetter: System.Char"

            float x = 1.8f; // тут произойдёт ошибка, так как мы ввели double число в переменную типа float; исправил добавив суффикс f
            char c = 'a'; // тут произойдёт ошибка, так как нужны одинарные кавычки; поправил исправив кавычки на одинарные
            var y = 5.0;
            Console.WriteLine(y.GetType().Name); // Выведет "Double", так как нету суффиксов
            float big = 16777217f;
            Console.WriteLine(big); // Выведет "1677721" из-за 7 максимально возможных чисел; тут понял ошибку, все значения после 2^24/16777216 - он начинает округлять до чётных чисел в ближайшую к презентабельной форму в меньшую сторону

            float a = 16777218f;
            Console.WriteLine(a); // тут вывод будет "16777218", так как это само по себе чётное число
            Console.WriteLine(0.1 + 0.2 == 0.3); // тут будет выведено "False", так как в двоичном виде это неточные значения
            float b = 0.1f;
            Console.WriteLine(b == 0.1); // тут будет выведено "False", так как сравниваются разные типы данных с разной точностью и двоичным представлением
            Console.WriteLine(1f / 3f); // тут я не знаю что будет выведено

            Console.WriteLine(0.1f + 0.2f); // тут будет выведено 0,3
            Console.WriteLine(0.1f + 0.2f == 0.3f); // тут будет выведено true
        }
    }
}
