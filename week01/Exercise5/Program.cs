using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUsername();
        int number = PromptUsernumber();
        int square = SquareNumber(number);

        Console.WriteLine ($"{name}, The square of your number is: {square}");

        number = -1;
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUsername()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
        static int PromptUsernumber()
        {
            Console.WriteLine("What is your favourite number?");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            return number * number;
            
        }
        
    }
}