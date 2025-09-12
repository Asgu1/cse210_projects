using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int magicNumber = 7;

        int numberGuessed = -1;

        do
        {
            Console.Write("Guess a number: ");
            numberGuessed = int.Parse(Console.ReadLine());

            if (numberGuessed < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (numberGuessed > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("That's correct");
            }
        } while (numberGuessed != magicNumber);
        


    }
}