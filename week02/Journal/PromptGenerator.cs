using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What positive experience did you have today?",
            "What negative experience did you have today?",
            "What spiritual experience did you have today?",
            "What lesson did you learn from your experieces today?",
            "How did you overcome a difficult situation today?"
           
        };

        _random = new Random();
    }
    
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
