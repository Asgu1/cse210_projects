using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int numberObtained = -1;

        while (numberObtained != 0)
        {
            Console.Write("Enter a number: ");
            numberObtained = int.Parse(Console.ReadLine());

            if (numberObtained != 0)
            {
                numbers.Add(numberObtained);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The total is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        
    }
}