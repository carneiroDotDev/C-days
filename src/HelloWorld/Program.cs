// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello, World!";
            Console.WriteLine(a);
            string? userInput = Console.ReadLine();
            Console.WriteLine(a + ". You wrote... " + userInput);
        }
    }
}
