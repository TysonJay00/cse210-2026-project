using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);


        string letter = "";


        if (percent >= 90)
        {
            letter = "A";

        }
        else if (percent >= 80 && percent < 90)
        {
            letter = "B";

        }
        else if (percent >= 70 && percent < 80)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent < 70)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }

        else
        {
            Console.WriteLine("You must type a number");
        }

        Console.WriteLine($"Your Grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else if (percent < 70)
        {
            Console.WriteLine("Unfortunately, you did not pass the Course");
        }




    }
}