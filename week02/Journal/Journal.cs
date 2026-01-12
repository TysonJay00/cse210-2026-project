using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

/* I added to my program, in this file, to help the user know what happens if they try entering an entry that's blank, 
that they won't be able to save it and it returns to the options section. Shown in lines 35 to 39 in the AddEntry function.*/

public class Journal
{



    public List<Entry> _entries = new List<Entry>();
    public List<Entry> GetEntries()
    {
        return _entries;
    }
    public void AddEntry(Entry newentry)
    {
        Entry newEntry = new Entry();
        DateTime now = DateTime.Now;
        string _date = now.ToString();
        newEntry._dateText = _date;

        PromptGenerator pg = new PromptGenerator();
        string prompt = pg.GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);

        newEntry._promptText = prompt;
        Console.Write("Write your journal entry:");
        string input = Console.ReadLine();



        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entry cannot be empty. Entry will not be saved.");
            return;
        }
        newEntry._entryText = input;
        newEntry._isSaved = false; 

        _entries.Add(newEntry);
        

    }
    public void DisplayAll()
    {
        Console.WriteLine("Your Journal Entries:");
        foreach (Entry entry in _entries) 
        {
            entry.Display();
        }

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, append: false))
        {
            foreach (Entry entry in _entries)
            {
                if (!entry._isSaved)
                {
                    writer.WriteLine(entry.GetFormattedEntry());
                    entry._isSaved = true;
                }
            }
            
        }
        Console.WriteLine("Entry saved to file.");
    }
    public void LoadFromFile(string file)
    {
        
        
        
        if (!File.Exists(file))
        {
            Console.WriteLine($"File not found: {file}");
            return;
        }
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _dateText = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],
                };
                _entries.Add(entry);


            }
            else
            {
                Console.WriteLine("");
            }
        }
        

    }
    }
