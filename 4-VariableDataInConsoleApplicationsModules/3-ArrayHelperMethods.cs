namespace csharpfoundations;

public class ArrayHelperMethods
{
    public static void Run()
    {
        string[] pallets = { "B14", "A11", "B12", "A13" };

        // Sort()
        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Reverse()
        Console.WriteLine();
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Clear() leaves a null value, not empty string
        Console.WriteLine();
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Resize() requires ref to re-malloc the memory
        // Resizing down can trim the end elements of the array by just leaving the values in unreferenced memory
        Console.WriteLine();
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Reversing a string by conversion to character array
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        string result = new string(valueArray);
        Console.WriteLine(result);

        // Using Join() to comma separate values
        result = String.Join(",", valueArray);
        Console.WriteLine(result);

        // Using Split() to separate them
        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

        // Exercise 1 is to reverse each word in a message
        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] words = pangram.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] temp = words[i].ToCharArray();
            Array.Reverse(temp);
            words[i] = new string(temp);
        }
        Console.WriteLine(String.Join(' ', words));

        // Exercise 2 is to sort order IDs and mark ones that aren't length == 4
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orders = orderStream.Split(',');
        Array.Sort(orders);
        foreach (var order in orders)
        {
            string temp = (order.Length == 4) ? "" : " - Error";
            Console.WriteLine($"{order}{temp}");
        }
    }
}