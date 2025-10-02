using System;
using System.Collections.Generic;

class Program
{
    // Exceeding requirements:
    // - Uses a library of scriptures (multiple entries) instead of a single one
    // - Presents scriptures at random to the user in each round
    // - Keeps looping until the user types 'quit'
    static void Main(string[] args)
    {
        // Library of scriptures: tuple of (Reference, Text)
        var library = new List<(Reference Ref, string Text)>
        {
            (new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            (new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            (new Reference("Philippians", 4, 13),
                "I can do all things through Christ who strengthens me."),
            (new Reference("Psalms", 23, 1),
                "The Lord is my shepherd; I shall not want.")
        };

        var random = new Random();

        Console.WriteLine("=== SCRIPTURE MEMORIZER ===");
        Console.WriteLine();

        while (true)
        {
            var pick = library[random.Next(library.Count)];
            var scripture = new Scripture(pick.Ref, pick.Text);

            PracticeScripture(scripture);

            Console.Write("Press Enter for another random scripture, or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
        }

        Console.WriteLine("Thank you for using the Scripture Memorizer!");
    }

    static void PracticeScripture(Scripture scripture)
    {
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Practice ended. Keep practicing!");
                return;
            }
            scripture.HideRandomWords(3);
        }
        Console.WriteLine("🎉 CONGRATULATIONS! 🎉");
        Console.WriteLine("You have completely memorized this scripture!");
    }
}
