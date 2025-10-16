using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base(
        "Listing", 
        "This activity will help you reflect on the good things in your life by having you " +
        "list as many things as you can in a certain area.")
    {
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are things you are grateful for today?",
            "What achievements have you reached recently?",
            "What happy moments have you had this week?",
            "What qualities do you admire in yourself?",
            "What positive experiences have you had this month?"
        };
    }

    public override void Run()
    {
        ShowStartingMessage();
        
        // Show a random prompt
        Random random = new Random();
        string selectedPrompt = _prompts[random.Next(_prompts.Count)];
        
        Console.WriteLine($"Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {selectedPrompt} ---");
        Console.WriteLine();
        
        // Countdown for user to prepare
        Console.WriteLine("Get ready to begin...");
        ShowCountdown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        List<string> items = new List<string>();
        
        Console.WriteLine("Begin listing items (press Enter after each one):");
        Console.WriteLine();
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
                Console.WriteLine($"✓ Added: {item}");
            }
            
            // Show remaining time
            TimeSpan remaining = endTime - DateTime.Now;
            if (remaining.TotalSeconds > 0)
            {
                Console.WriteLine($"Time remaining: {remaining.Seconds} seconds");
            }
        }
        
        // Show summary
        Console.WriteLine();
        Console.WriteLine($"Excellent! You have listed {items.Count} items:");
        Console.WriteLine();
        
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
        
        ShowEndingMessage();
    }
}
