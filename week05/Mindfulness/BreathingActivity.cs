using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing", 
        "This activity will help you relax by walking you through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        ShowStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        bool breatheIn = true;
        
        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            
            // Show breathing animation
            ShowBreathingAnimation(breatheIn);
            
            breatheIn = !breatheIn;
        }
        
        ShowEndingMessage();
    }

    private void ShowBreathingAnimation(bool breatheIn)
    {
        if (breatheIn)
        {
            // Inhale animation - growing circle
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"\rBreathing in");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Thread.Sleep(1000);
            }
        }
        else
        {
            // Exhale animation - shrinking circle
            for (int i = 4; i >= 1; i--)
            {
                Console.Write($"\rBreathing out");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine();
    }
}
