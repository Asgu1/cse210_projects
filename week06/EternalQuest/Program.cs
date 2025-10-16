

using System;

class Program
{
    static void Main(string[] args)
    {
        // Eternal Quest - Menu
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"Score: {manager.Score}  |  Level: {manager.Level}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    RecordEvent(manager);
                    break;
                case "4":
                    Console.Write("File path to save: ");
                    manager.Save(Console.ReadLine());
                    break;
                case "5":
                    Console.Write("File path to load: ");
                    manager.Load(Console.ReadLine());
                    break;
                case "6":
                    // Extra credit note: level system (1000 points per level) implemented
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Unknown type.");
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.WriteLine("Select goal to record:");
        manager.ListGoals();
        Console.Write("Number: ");
        if (int.TryParse(Console.ReadLine(), out int idx))
        {
            manager.RecordEvent(idx - 1);
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
}