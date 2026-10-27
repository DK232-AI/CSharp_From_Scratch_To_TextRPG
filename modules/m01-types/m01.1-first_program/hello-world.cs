using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            string bFriend = "Maira";
            Console.WriteLine("Hello, " + bFriend);
            Console.WriteLine($"Hello, {bFriend}");

            string cFriend = "Svetlana";
            string dFriend = "Andrew";
            Console.WriteLine($"Hello, {cFriend} and {dFriend}!");
            Console.WriteLine($"Name {cFriend} has {cFriend.Length} letters.");
            Console.WriteLine($"Name {dFriend} has {dFriend.Length} letters.");

            string greeting = "        Hello, World!          ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";   
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
        }
    }
}