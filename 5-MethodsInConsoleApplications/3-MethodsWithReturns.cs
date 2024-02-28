namespace csharpfoundations;

public class MethodsWithReturns
{
    public static void Run()
    {
        // I'm done keeping all the methods together if they want to use so many globals
        double total = 0;
        double minimumSpend = 30.00;

        double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
        double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

        for (int i = 0; i < items.Length; i++)
        {
            total += GetDiscountedPrice(i);
        }

        total -= TotalMeetsMinimum() ? 5.00 : 0.00;

        Console.WriteLine($"Total: ${FormatDecimal(total)}");
        Console.WriteLine();

        double GetDiscountedPrice(int itemIndex)
        {
            return items[itemIndex] * (1 - discounts[itemIndex]);
        }

        bool TotalMeetsMinimum()
        {
            return total >= minimumSpend;
        }

        string FormatDecimal(double input)
        {
            return input.ToString().Substring(0, 5);
        }

        // Returning ints and doubles
        double usd = 23.73;
        int vnd = UsdToVnd(usd);

        Console.WriteLine($"${usd} USD = ${vnd} VND");
        Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
        Console.WriteLine();

        int UsdToVnd(double usd) 
        {
            int rate = 23500;
            return (int) (rate * usd);
        }

        double VndToUsd(int vnd) 
        {
            double rate = 23500;
            return vnd / rate;
        }

        // Returning a string from a method
        string input = "there are snakes at the zoo";

        Console.WriteLine(input);
        Console.WriteLine(ReverseSentence(input));
        Console.WriteLine();

        string ReverseSentence(string input) 
        {
            string result = "";
            string[] words = input.Split(" ");
            foreach(string word in words) 
            {
                result += ReverseWord(word) + " ";
            }
            return result.Trim();
        }

        string ReverseWord(string word) 
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                result += word[i];
            }
            return result;
        }

        // Returning booleans

        string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words) 
        {
            Console.WriteLine($"{word}: {IsPalindrome(word)}");
        }

        Console.WriteLine();

        bool IsPalindrome(string word) 
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end) 
            {
                if (word[start] != word[end]) 
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

        // Returning arrays from method calls
        int target = 30;
        int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
        int[,] result = TwoCoins(coins, target);

        if (result.Length == 0) 
        {
            Console.WriteLine("No two coins make change");
        } 
        else 
        {
            Console.WriteLine("Change found at positions:");
            for (int i = 0; i < result.GetLength(0); i++) 
            {
                if (result[i,0] == -1) 
                {
                    break;
                }
                Console.WriteLine($"{result[i,0]},{result[i,1]}");
            }
        }

        Console.WriteLine();

        int[,] TwoCoins(int[] coins, int target) 
        {
            int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
            int count = 0;

            for (int curr = 0; curr < coins.Length; curr++) 
            {
                for (int next = curr + 1; next < coins.Length; next++) 
                {    
                    if (coins[curr] + coins[next] == target) 
                    {
                        result[count, 0] = curr;
                        result[count, 1] = next;
                        count++;
                    }
                    if (count == result.GetLength(0)) 
                    {
                        return result;
                    }
                }
            }
            return (count == 0) ? new int[0,0] : result;
        }

        // Challenge is to write the methods for the below code to make the game work
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay()) 
        {
            PlayGame();
        }

        void PlayGame() 
        {
            Random random = new();
            var play = true;

            while (play) 
            {
                int target;
                int roll;

                target = random.Next(1,6);
                roll = random.Next(1,7);

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(target, roll));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        // Challenge methods
        string WinOrLose(int target, int roll)
        {
            if (roll > target)
            {
                return "You Win!";
            }
            return "You Lose!";
        }

        bool ShouldPlay()
        {
            string? test = Console.ReadLine();
            if (!(test == null))
            {
                if (test.ToLower() == "y")
                {
                    return true;
                }
                else if(test.ToLower() == "n")
                {
                    return false;
                }
            }
            Console.WriteLine("Y or N please:");
            // Recursive! How insane
            return ShouldPlay();
        }
    }
}