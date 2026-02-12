using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
        ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                
                breathing.run();
            }
            else if (choice == "2")
            {
                reflecting.run();
            }

            else if (choice == "3")
            {
                listing.run();
                
            }
        
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Please choose one of the following choices by their given numbers.");
            }











        }
    }
}