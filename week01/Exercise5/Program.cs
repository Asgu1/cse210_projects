using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = PromptSquareNumber(favNumber);

        DisplayResult(userName, squareNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number? ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static int PromptSquareNumber(int favNumber)
    {
        int squareNumber = favNumber * favNumber;

        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"Brother {userName}, the square of your number is {squareNumber}");
    }

}