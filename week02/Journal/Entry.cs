using System;
using System.Reflection.Metadata.Ecma335;

public class Entry
{
    public string _entryText;
    public string _dateText;
    public string _promptText;

    public string GetFormattedEntry()
    {
        return $"{_dateText}|{_promptText}|{_entryText}";
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_dateText}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
        Console.WriteLine("----------------");


    }

    public bool _isSaved = false;
    
    
}