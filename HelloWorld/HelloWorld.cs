using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld my name is Bob");
            Console.WriteLine("What is your name?");
            String userInput = Console.ReadLine();
            Console.WriteLine("Nice to meet you"+userInput);

        }
    }
}
