using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void displayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");

        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    public void DispayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Console.WriteLine();

        
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)

        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}