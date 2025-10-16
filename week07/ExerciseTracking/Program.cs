using System;

class Program
{
    static void Main(string[] args)
    {
        // Create sample activities (km-based)
        var run = new Running(new DateTime(2022, 11, 3), 30, 4.8); // distance in km
        var bike = new Cycling(new DateTime(2022, 11, 3), 40, 24.0); // avg speed kph
        var swim = new Swimming(new DateTime(2022, 11, 3), 30, 48); // 48 laps = 2.4 km

        Activity[] activities = { run, bike, swim };

        foreach (var a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}