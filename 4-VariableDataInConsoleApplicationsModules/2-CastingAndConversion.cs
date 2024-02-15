using Microsoft.VisualBasic;

namespace csharpfoundations;

public class CastingAndConversions
{
    public static void Run()
    {
        // Compilers implicitly performs widening conversions
        int first = 2;
        string second = "4";
        string result = first + second;
        Console.WriteLine(result);

        // int result = first + second
        // Fails because it will not implicitly narrow data

        // Another widening
        int myInt = 3;
        Console.WriteLine($"int: {myInt}");

        decimal myDecimal = myInt;
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine();

        // Have to cast data types to narrow
        // Lets the compiler know I'm okay with losing precision
        myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");

        myInt = (int)myDecimal;
        Console.WriteLine($"int: {myInt}");

        // ToString methods
        first = 5;
        int secondInt = 7;
        string message = first.ToString() + secondInt.ToString();
        Console.WriteLine(message);

        // Parse methods
        string firstString = "5";
        second = "7";
        int sum = int.Parse(firstString) + int.Parse(second);
        Console.WriteLine(sum);

        // Handling of extra precision
        int value = (int)1.5m; // casting truncates
        Console.WriteLine(value);

        int value2int = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value2int);

        // TryParse, but we've used this before
        string valueString = "102";
        int resultInt;
        if (int.TryParse(valueString, out resultInt))
        {
            Console.WriteLine($"Measurement: {resultInt}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        // Excercise provided values below:
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        // Excercise is to sum all the numbers and concatenate the strings
        message = ""; decimal total = 0;
        foreach (string str in values)
        {
            decimal temp;
            if (decimal.TryParse(str, out temp))
            {
                total += temp;
            }
            else
            {
                message += str;
            }
        }
        Console.WriteLine($"Message: {message}\nTotal: {total}");

        // Next exercise is below
        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        // Your code here to set result1
        int result1 = Convert.ToInt32(value1 / value2);
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        // Your code here to set result2
        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        // Your code here to set result3
        float result3 = value3 / value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
}