namespace csharpfoundations;

public class LoopingLogicUsingDoWhile
{
    public static void Run()
    {
        // Do While and While loops
        Random random = new Random();
        int current;

        do
        {
            // This will always run at least once
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);
        // Until the while condition isn't met

        // This one will not run at all if the condition isn't met
        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");

        // break will still exit loops
        // continue will finish that iteration of the loop and reassess the condition

        // The challenge is to implement the following rules
        /*
        You must use either the do-while statement or the while statement as an outer game loop.
        The hero and the monster will start with 10 health points.
        All attacks will be a value between 1 and 10.
        The hero will attack first.
        Print the amount of health the monster lost and their remaining health.
        If the monster's health is greater than 0, it can attack the hero.
        Print the amount of health the hero lost and their remaining health.
        Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
        Print the winner.
        */
        // I have done so below:

        int heroHealth = 10; int monsterHealth = 10;
        // Random random = new();
        // Not required because already defined in this scope

        while (heroHealth > 0 && monsterHealth > 0)
        {
            int damage = random.Next(1, 11);
            monsterHealth -= damage;
            Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Hero Wins!");
                break;
            }

            damage = random.Next(1,11);
            heroHealth -= damage;
            Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");

            if (heroHealth <= 0)
            {
                Console.WriteLine("Monster Wins!");
                break;
            }
        }

        // Provided solution contained:
        // Console.WriteLine(hero > monster ? "Hero Wins" : "Monster Wins");
        // Which is an improvement over my logic in my opinion

        // Reading user input via a do while loop
        // Commented out for ease of running via controller
        /*
        string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter a string containing at least three characters:");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if (readResult.Length >= 3)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Your input is invalid, please try again.");
                }
            }
        } while (validEntry == false);
        */

        // Challenge 1 requires the following:
        /*
        Do While or While iteration
        Prompt user for integer between 5 and 10
        Validate the data entry
        Inform the user the data is accepted
        */
        // Implemented below:

        string? readResult;
        bool valid = false;
        int readNumber;
        Console.WriteLine("Please enter a number between 5 and 10");
        do
        {
            readResult = Console.ReadLine();
            valid = int.TryParse(readResult, out readNumber);
            if (valid)
            {
                if (!(readNumber >= 5 && readNumber <= 10))
                {
                    valid = false;
                    Console.WriteLine("Please ensure your number is between 5 and 10");
                }
            }
            else
            {
                Console.WriteLine("Please ensure your input is a number");
            }
        } while (!valid);
        Console.WriteLine($"Thank you for your input: {readNumber}");

        // Challenge 2 requires the following:
        /*
        Do While or While iteration
        Prompt user for Administrator, Manager, or User input
        Use Trim() to remove whitepace
        Use ToLower() to remove case sensitivity
        */
        // Implemented below:

        readResult = null; valid = false;
        Console.WriteLine("Please enter user type (Administrator, Manager, or User)");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                readResult = readResult.ToLower().Trim();
                if (readResult == "administrator" || readResult == "manager" || readResult == "user")
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please input a correct user type");
                }
            }
            else
            {
                Console.WriteLine("Please enter user type (Administrator, Manager, or User)"); 
            }
        } while (!valid);
        Console.WriteLine($"Thank you for your input: {readResult}");

        // Provided code for Challenge 3:
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad",
                                                "I like all three of the menu choices" };

        // My code for Challenge 3:
        int periodLocation = 0;

        // For the whole array
        foreach (var str in myStrings)
        {
            // Don't want to edit the input
            string myString = str;
            periodLocation = myString.IndexOf(".");
            while (periodLocation != -1)
            {
                // Grab each sentence
                string temp = myString.Substring(0, periodLocation);
                Console.WriteLine(temp);
                // Remove what was printed plus the period
                myString = myString.Remove(0, periodLocation + 1).TrimStart();
                periodLocation = myString.IndexOf(".");
            }
            // Print what is left or a no period string
            Console.WriteLine(myString.Trim());
        }
    }
}