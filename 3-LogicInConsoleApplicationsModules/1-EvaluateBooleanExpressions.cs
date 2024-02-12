namespace csharpfoundations;

public class EvaluateBooleanExpressions
{
    public static void Run()
    {
        // Intro to expressions
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");

        // Showing case sensitivity
        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

        // Comparisons
        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);

        // Methods that return bools
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));

        // Logical negation
        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));

        // Conditional operator
        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");
        // Also inline
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

        // The challenge is to implement a coin flip using random and the conditional operator
        // Code is below
        System.Random random = new();
        int flip = random.Next(0, 2);
        Console.WriteLine($"{(flip == 0 ? "heads" : "tails")}");

        /*
        The challenge is to implement the following rules:
        Admin & Level > 55 has one execution path
        Admin & Level <= 55 has another
        Manager & Level >= 20 has another
        Manager & Level < 20 has another
        Not Admin or Manager has another
        Below is the provided setup code
        */
        string permission = "Admin|Manager";
        int level = 55;

        // Below is my own code
        bool admin = permission.ToLower().Contains("admin");
        bool manager = permission.ToLower().Contains("manager");
        if (admin && level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else if (admin)
        {
            Console.WriteLine("Welcome, Admin user.");
        }
        else if (manager && level >= 20)
        {
            Console.WriteLine("Contact an Admin for access.");
        }
        else if (manager)
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
}