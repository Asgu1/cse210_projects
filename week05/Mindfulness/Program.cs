using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("This program will help you relax and reflect.");
        Console.WriteLine();
        
        bool continueProgram = true;
        
        while (continueProgram)
        {
            ShowMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                    
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;
                    
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                    
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    Console.WriteLine("Have a peaceful and reflective day!");
                    continueProgram = false;
                    break;
                    
                default:
                    Console.WriteLine("Invalid option. Please select 1, 2, 3, or 4.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
    
    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine("==================");
        Console.WriteLine();
        Console.WriteLine("Select an activity:");
        Console.WriteLine();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("   - Deep breathing exercises for relaxation");
        Console.WriteLine();
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("   - Deep reflection on meaningful experiences");
        Console.WriteLine();
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("   - List positive aspects of your life");
        Console.WriteLine();
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Select an option (1-4): ");
    }
}