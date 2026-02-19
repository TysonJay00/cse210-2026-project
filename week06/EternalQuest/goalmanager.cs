using System;
using System.Collections.Generic;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu:");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();

            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                SaveGoals();

            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else if (choice != "6")
            {
                Console.WriteLine("Invalid choice.\n");
            }
        }   
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?");

        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal?");
        string points = Console.ReadLine();

        if (typeChoice == "1")
        {
            Goal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        if (typeChoice == "2")
        {
            Goal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        if (typeChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished?");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());

            Goal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }

        Console.WriteLine("Goal created!\n");


    }

    
    
    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish?");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];

        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();

        int pointsEarned = goal.GetPointValue();
        int bonusEarned = 0;

        if (goal is ChecklistGoal checklist)
        {
            if (!wasComplete && checklist.IsComplete())
            {
                bonusEarned = checklist.GetBonus();
                _score += bonusEarned;

                Console.WriteLine("Bonus achieved!");
            }

            _score += pointsEarned;


        }

        Console.WriteLine($"Congratulations! You earned {pointsEarned + bonusEarned} points for this goal!");
        
        

    }
    

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved!\n");

    }

    public void LoadGoals()
    {
        Console.Write("What is the filename?");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++) 
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                bool complete = bool.Parse(parts[4]);
                
                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetComplete(complete);

                _goals.Add(goal);
            }

            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                _goals.Add(new EternalGoal(name, description, points));

            }

            
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

                goal.SetAmountCompleted(amountCompleted);

                _goals.Add(goal);
}



        }

        Console.WriteLine("Goals Loaded!");
    }
}