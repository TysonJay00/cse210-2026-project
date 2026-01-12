using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");


        List<int> numberslist = new List<int>();
        int number = -1;

        while (number != 0)
        {

            Console.WriteLine("Enter Number:");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numberslist.Add(number);
            }



        }
        int sum = 0;
        foreach (int num in numberslist)
        {
            sum += num;

        }
        Console.WriteLine($"The sum is: {sum}");

        double average = 0;

        if (numberslist.Count > 0)
        {

            average = (double)sum / numberslist.Count;
            Console.WriteLine($"The Average is: {average}");

        }
        int max = numberslist[0];
        foreach (int num in numberslist)
        {
            if (num > max)
            {
                max = num;
            }

        }
        Console.WriteLine($"The Largest number is: {max}");
    }
    
    
}