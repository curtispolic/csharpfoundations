using System;

namespace csharpfoundations;

public class DecisionLogic
{
    public static void Run()
    {
        // Initial code to randomise 3 numbers and sum them.
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        // This was added after the fox section, to implement a doubles bonus
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            // This was added as a triples bonus, but as a seperate if to teach how to do nested logic
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            // Added a total count
            Console.WriteLine($"Your total including the bonus: {total}");
        }
        

        // Decision logic
        if (total > 14)
        {
            Console.WriteLine("You win!");
        }
        // Originally a 2nd if but it should be an else
        else
        {
            Console.WriteLine("Sorry, you lose.");
        }

        // This teaches me what a bool is
        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }

        // Below is the challenge code
        // I reused my dice object because it's all in the same method
        int daysUntilExpiration = dice.Next(12);
        int discountPercentage = 0;

        /*
        I must use both variables above and must follow the following rules:

        Rule 1: Your code should only display one message.
        The message that your code displays will depend on the other five rules.
        For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

        Rule 2: If the user's subscription will expire in 10 days or less, display the message:
            Your subscription will expire soon. Renew now!

        Rule 3: If the user's subscription will expire in five days or less, display the messages:
            Your subscription expires in _ days.
            Renew now and save 10%!

        Rule 4: If the user's subscription will expire in one day, display the messages:
            Your subscription expires within a day!
            Renew now and save 20%!

        Rule 5: If the user's subscription has expired, display the message:
            Your subscription has expired.

        Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.

        It also asks that I implement this using if and else statements
        */

        if (daysUntilExpiration <= 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }

        // Print via this to use the variable to prevent compilation warnings
        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }

        // As the remaining case is to display nothing, it doesn't need to be handled

    }
}