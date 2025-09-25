using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements: added JSON save/load support when filename ends with .json
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string option = string.Empty;
        while (option != "5")
        {
            Console.WriteLine("My Journal");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._promptText = prompt;
                entry._entryText = response;

                myJournal.AddEntry(entry);
                Console.WriteLine("Entry saved.");
            }
            else if (option == "2")
            {
                Console.WriteLine("\n--- Journal ---");
                myJournal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.Write("Filename to save: ");
                string filename = Console.ReadLine();
                try
                {
                    myJournal.SaveToFile(filename);
                    Console.WriteLine("Journal saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving: {ex.Message}");
                }
            }
            else if (option == "4")
            {
                Console.Write("Filename to load: ");
                string filename = Console.ReadLine();
                try
                {
                    myJournal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading: {ex.Message}");
                }
            }
            else if (option == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}