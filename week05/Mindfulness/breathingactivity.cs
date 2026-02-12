using System;
using System.Threading;

public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description, int duration)
       
       : base(name, description, duration)
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }
    public void run()
    {
        displayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            if (DateTime.Now >= endTime) break;

            Console.WriteLine("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DispayEndingMessage();
        
        
    }
}