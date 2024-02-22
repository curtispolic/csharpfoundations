using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace csharpfoundations;

public class FirstMethod
{
    public static void Run()
    {
        static void DisplayRandomNumbers() 
        {
            // Display 5 random numbers
            Random random = new Random();

            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"{random.Next(1, 100)} ");
            }

            Console.WriteLine();
        }

        void DisplayTimes(int[] times) 
        {
            // Format and display times
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }

            Console.WriteLine();
        }

        void AdjustTimes(int[] times, int diff) 
        {
            // Adjust the times by adding the difference
            for (int i = 0; i < times.Length; i++) 
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        }

        bool ConfirmFourNumbers(string ip)
        {
            // Confirm there are only 4 numbers in the address
            string[] split = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
            foreach (string num in split)
            {
                if (!int.TryParse(num, out _))
                {
                    return false;
                }
            }
            if (split.Length == 4)
            {
                return true;
            }
            return false;
        }

        bool ConfirmNoLeadingZeroes(string ip)
        {
            // Confirm there are no leading zeroes in each number
            string[] split = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
            foreach (string num in split)
            {
                char[] characters = num.ToCharArray();
                if (characters[0] == '0' && characters.Length > 1)
                {
                    return false;
                }
            }
            return true;
        }

        bool ConfirmNumberRange(string ip)
        {
            // Checks the numbers in an IP are 0 <= IP < 256
            string[] split = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
            foreach (string num in split)
            {
                int test;
                if (int.TryParse(num, out test))
                {
                    if (!(test >= 0 && test < 256))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        Console.WriteLine("Generating random numbers:");
        DisplayRandomNumbers();

        // Using methods to reuse code
        int[] times = {800, 1200, 1600, 2000};
        int diff = 0;

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes(times);

        Console.WriteLine();

        Console.WriteLine("Enter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        // Determine the difference in timezones
        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustTimes(times, diff);
        } 
        else 
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustTimes(times, diff);
        }

        Console.WriteLine();

        Console.WriteLine("New Medicine Schedule:");
        DisplayTimes(times);

        Console.WriteLine();

        // IP verification
        string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};

        foreach (string ip in ipv4Input) 
        {
            bool validNumbers = ConfirmFourNumbers(ip);
            bool validZeroes = ConfirmNoLeadingZeroes(ip);
            bool validRange = ConfirmNumberRange(ip);

            if (validNumbers && validZeroes && validRange) 
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            } 
            else 
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        // Fortune telling challenge
        void FortuneTelling(int luck)
        {
            string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
            string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
            string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
            string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
            for (int i = 0; i < 4; i++) 
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
        }

        Console.WriteLine();
        Random random = new();
        int luck = random.Next(100);
        FortuneTelling(luck);
        Console.WriteLine();
    }
}