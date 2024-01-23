using System;

namespace csharpfoundations
{
	public class StoreAndIterateOverArrays
	{
		public static void Run()
		{
            // Declaring an array
            string[] fraudulentOrderIDs = new string[3];

            // Assigning values
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            // Access the values
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            // Reassign and access
            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            // Making a second array instead of commenting out code
            string[] moreFraudulentOrderIDs = {"111", "222", "333"};

            // Using the properties of the array
            Console.WriteLine($"There are {moreFraudulentOrderIDs.Length} fraudulent orders to process.");

            // foreach loops and arrays
            string[] names = { "Rowena", "Robin", "Bao" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Iterating over an array and summing while printing each iteration
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            // Below is the challenge code
            // Make an array with the provided IDs
            string [] challengeIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
            
            // Iterate over it and print the IDs that start with B
            foreach (string ID in challengeIDs)
            {
                // Funny they don't teach you one-liners
                if (ID.StartsWith("B")) Console.WriteLine(ID);
            }
        }
    }
}

