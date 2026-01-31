using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("John", 3, 16);

        string scriptureText = "For God so loved the world that He gave His only Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;

            }
            else if (input == "")
            {
                scripture.HideRandomWords(1);
            }

            scripture.HideRandomWords(1);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        
    }


       

}