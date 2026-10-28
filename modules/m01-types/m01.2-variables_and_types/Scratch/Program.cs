using System;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = 8_000_000; // stores 32-bit integers (-2,147,483,648 to 2,147,483,647)
            long distance = 2_000_000_000; // stores 64-bit integers (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
            short temperature = -20; // stores 16-bit integers (-32,768 to 32,767)
            byte age = 37; // stores 8-bit integers (0 to 255)

            float price = 4.99f; // stores 32-bit floating point numbers, usually used for calculations where precision is not critical (7 digits of precision)
            double balance = 1_000_000.99; // stores 64-bit floating point numbers, usually used for scientific calculations (15-16 digits of precision)
            decimal tax = 0.99m; // stores 128-bit precise decimal values, usually used for financial calculations and other things that people expect to see in this format (28-29 significant digits)

            uint naturalNumber = 23; // stores 32-bit unsigned integers (0 to 4,294,967,295)
            ulong bigNaturalNumber = 2_000_000_000; // stores 64-bit unsigned integers (0 to 18,446,744,073,709,551,615)
            ushort smallNaturalNumber = 7; // stores 16-bit unsigned integers (0 to 65,535)

            nint negativeNumber = -23; // stores 32-bit integers (-2,147,483,648 to 2,147,483,647)
            nuint positiveNumber = 23; // stores 32-bit unsigned integers (0 to 4,294,967,295)

            bool isWorking = true; // stores true or false values
            char letter = 'A'; // stores a single character/letter, surrounded by single quotes
            string text = "Hello World"; // stores a sequence of characters, surrounded by double quotes

            var IamVariable = 32; //it infers a suitable type for the variable based on the value assigned to it. In this case, it infers that IamVariable is of type int.
            var IamVariable2 = "Hello World"; // in this case, it infers that IamVariable2 is of type string.

            const double Pi = 3.14159; // stores a constant value that cannot be changed after it is initialized
            const string Greeting = "Hello World"; // stores a constant value that cannot be changed after it is initialized
        }
    }
}