using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    private string _currentPrompt;
    public ListingActivity(string name, string description, int duration)

      : base(name, description, duration)
    {
        
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        

    }

    public void run()
    {
        displayStartingMessage();


        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");

        GetRandomPrompt();
        
        Console.WriteLine();
        Console.WriteLine($"------- {_currentPrompt} -------");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine($"You listed {_count} items!");

        DispayEndingMessage();

    }


    public void GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0)
        {
            _currentPrompt = "No prompts available";
            return;
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        _currentPrompt = _prompts[index];
    }



    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write(">");

            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }
        return responses;
    }


}

