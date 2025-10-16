using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base(
        "Reflection", 
        "This activity will help you reflect on times in your life when you have shown " +
        "strength and resilience. This will help you recognize the power you have and how you can " +
        "use it in other aspects of your life.")
    {
        InitializePrompts();
        InitializeQuestions();
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you overcame a great personal challenge.",
            "Think of a time when you inspired another person."
        };
    }

    private void InitializeQuestions()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "What qualities did you show during this experience?",
            "How did this experience change you?",
            "What advice would you give to someone in a similar situation?"
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
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        // Show random questions until time runs out
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine();
            Console.WriteLine(question);
            Console.WriteLine();
            
            // Show spinner while user reflects
            ShowSpinner(5);
        }
        
        ShowEndingMessage();
    }
}
