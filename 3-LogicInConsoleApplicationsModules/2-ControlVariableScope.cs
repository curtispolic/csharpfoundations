namespace csharpfoundations;

public class ControlVariableScope
{
    public static void Run()
    {
        // Showing where / when assigning and initializing variables
        bool flag = true;
        int value = 0;

        if (flag)
        {
            // If init here, will not be accessible outside
            Console.WriteLine($"Inside the code block: {value}");
        }

        value = 10;
        Console.WriteLine($"Outside the code block: {value}");

        // Can put one-liners after an if without braces
        if (flag)
            Console.WriteLine(flag);

        // Also just entirely one line, whitespace has never mattered
        if (flag) Console.WriteLine(flag);
        // It's always just for readability 

        // Challenge is to fix the below code:
        /*
        int[] numbers = { 4, 8, 15, 16, 23, 42 };

        foreach (int number in numbers)
        {
            int total;

            total += number;

            if (number == 42)
            {
            bool found = true;

            }

        }

        if (found) 
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");
        */

        // I have done so below:

        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {
            total += number;

            if (number == 42)
            // I just need the braces
            {
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine("Set contains 42");
        }

        Console.WriteLine($"Total: {total}");
    }
}