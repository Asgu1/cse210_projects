using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions f = new Fractions();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fractions f2 = new Fractions(6);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        Fractions f3 = new Fractions(6, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
    }
}