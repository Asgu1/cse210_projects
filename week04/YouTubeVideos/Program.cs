using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("How to Learn C# Programming", "TechTutorials", 600);
        video1.NewComment("JohnDoe", "Great tutorial! Very helpful for beginners.");
        video1.NewComment("JaneSmith", "I've been looking for something like this. Thanks!");
        video1.NewComment("CodeMaster", "Excellent explanation of OOP concepts.");
        video1.NewComment("Student123", "This helped me understand classes better.");

        // Create second video
        Video video2 = new Video("Advanced C# Features", "CodeExpert", 1200);
        video2.NewComment("DeveloperPro", "Very advanced concepts explained well.");
        video2.NewComment("TechGuru", "Love the LINQ examples in this video.");
        video2.NewComment("CSharpFan", "Async/await explanation was perfect!");
        video2.NewComment("ProgrammingStudent", "Need to watch this again to fully understand.");

        // Create third video
        Video video3 = new Video("C# Best Practices", "SoftwareArchitect", 900);
        video3.NewComment("SeniorDev", "These practices have improved my code quality.");
        video3.NewComment("TeamLead", "Great guidelines for our development team.");
        video3.NewComment("CodeReviewer", "Clean code principles well explained.");
        video3.NewComment("JuniorDev", "This is exactly what I needed to learn.");

        // Create fourth video
        Video video4 = new Video("Building a Console Application", "AppBuilder", 750);
        video4.NewComment("AppDeveloper", "Step-by-step guide was very clear.");
        video4.NewComment("ConsoleAppFan", "Perfect for learning the basics.");
        video4.NewComment("NewbieCoder", "I can follow along easily with this tutorial.");
        video4.NewComment("ProjectManager", "Great foundation for larger applications.");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display information for each video
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine(); // Add blank line between videos
        }
    }
}