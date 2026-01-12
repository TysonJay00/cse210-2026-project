using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomnumber = new Random();
        int number = randomnumber.Next(1, 100);

        int guess = -1;

        while (guess != number)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (number > guess)
            {
                Console.WriteLine("Higher");

            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");

            }
            else
            {
                Console.WriteLine($"You guessed it! The magic number is {number}");
                
            }

            
            
        }
    }
}