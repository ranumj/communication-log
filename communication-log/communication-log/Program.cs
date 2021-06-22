using System;

namespace communication_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello pilot!");
            Console.WriteLine("Hello control!");
            Console.WriteLine("Wow it's actually working!");
            Console.WriteLine("Just wait until Microsoft sees this! We're basically engineers now.");

            Console.WriteLine("Please enter your name.");
            string input = Console.ReadLine();
            Console.WriteLine($"Your name is {input}.");
        }
    }
}
