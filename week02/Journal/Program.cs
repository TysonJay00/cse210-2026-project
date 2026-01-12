using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("MyJournal");



        Journal thejournal = new Journal();
        Entry anEntry = new Entry();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                thejournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            {
                thejournal.DisplayAll();
            }

            else if (choice == "3")
            {

                thejournal.LoadFromFile("entry.csv");
                List<Entry> loadedEntries = thejournal.GetEntries();

                foreach (Entry entry in loadedEntries)
                {
                    Console.WriteLine("Loaded Entry:");
                    entry.Display();
                }
            }
            else if (choice == "4")
            {


                thejournal.SaveToFile("entry.csv");
            }
            else if (choice == "5")
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