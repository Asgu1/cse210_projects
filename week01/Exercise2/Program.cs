using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your percent grade? ");
        string studentAnswer = Console.ReadLine();
        int studentGrade = int.Parse(studentAnswer);

        if (studentGrade >= 90)
        {
            Console.WriteLine("You got a A");
        }
        else if (studentGrade >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (studentGrade >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (studentGrade >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got a F, better luck next time");
        }        
    }
}