namespace csharpfoundations;

public class IterateUsingForStatements
{
    public static void Run()
    {
        // For statements
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // The other way
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
            if (i == 7) break;
            // break exits a loop
        }

        // Iterate over an array backwars
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
            // Useful if needing to edit or do certain things with an array that foreach can't
            // Foreach doesn't track index for example
        }

        // The challenge is to FizzBuzz to 100
        for (int i = 1; i <= 100; i++)
        {
            // I am proud
            Console.WriteLine($"{i} - {(i%3==0?"Fizz":"")}{(i%5==0?"Buzz":"")}");
            // Only because I don't want to flood my terminal
            if (i == 19) break;
        }
    }
}