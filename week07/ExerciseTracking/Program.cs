using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();
        string choice = "";
        while (choice != "4")
        {
           Console.WriteLine("Menu Options:");
           Console.WriteLine("1. Running");
           Console.WriteLine("2. Stationary Bicycling ");
           Console.WriteLine("3. Swimming");
           Console.WriteLine("4. Exit");
           Console.Write("Please choose an activity:");

           choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the length in minutes.");
                int length = int.Parse(Console.ReadLine());

                Console.Write("Enter the distance in kilometers.");
                double distance = double.Parse(Console.ReadLine());

                activities.Add(new RunningActivity(length, distance));

                var activity = new RunningActivity(length, distance); 
                activities.Add(activity);                              
                Console.WriteLine(activity.GetSummary());              


            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter the Length in minutes.");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the speed in kph");
                double speed = double.Parse(Console.ReadLine());

                var activity = new RunningActivity(length, speed);
                activities.Add(activity);                              
                Console.WriteLine(activity.GetSummary());  

            }

            else if (choice == "3")
            {
                Console.WriteLine("Enter the Length in minutes.");
                int length = int.Parse(Console.ReadLine());

                Console.Write("Enter the amount of laps you did");
                int laps = int.Parse(Console.ReadLine());

                activities.Add(new SwimmingActivity(length, laps));

                var activity = new RunningActivity(length, laps); 
                activities.Add(activity);                             
                Console.WriteLine(activity.GetSummary());              

            }

            
        }
        
    
    }
}