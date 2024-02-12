namespace csharpfoundations;

public class CallMethodsFromDotnetLibrary
{
    public static void Run()
    {
        // Using a system class
        Random dice = new Random();
        // Latest .NET allows Random dice = new() via implication which is neat

        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);

        // Showing the overloaded versions of the WriteLine() method
        int number = 7;
        string text = "seven";

        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine(text);

        // Same with then Next() method;
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        // Provided challenge code is below:
        /*
        int firstValue = 500;
        int secondValue = 600;
        int largerValue;

        Console.WriteLine(largerValue);
        */
        // The challenge is to find a System.Math method to assign largerValue

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = System.Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);
    }
}