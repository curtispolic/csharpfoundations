namespace csharpfoundations;

public class ExceptionHandling
{
    public static void Run()
    {
        // An example of try, catch, finally exception handling
        try
        {
            // Step 1: code execution begins
            try
            {
                // Step 2: an exception occurs here
            }
            finally
            {
                // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
            }

        }
        catch // Step 3: the system finds a catch clause that can handle the exception
        {   
        // Step 5: the system transfers control to the first line of the catch code block
        }

        // Intentional exceptions
        try
        {
            Process1();
        }
        catch
        {
            Console.WriteLine("An exception has occurred");
        }

        Console.WriteLine("Exit program");

        static void Process1()
        {
            WriteMessage();
        }

        static void WriteMessage()
        {
            double float1 = 3000.0;
            double float2 = 0.0;
            int number1 = 3000;
            int number2 = 0;

            Console.WriteLine(float1 / float2);
            Console.WriteLine(number1 / number2);
        }

        // Catching multiple possible exceptions
        string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

        foreach (string inputValue in inputValues)
        {
            int numValue = 0;
            try
            {
                numValue = int.Parse(inputValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid readResult. Please enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number you entered is too large or too small.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Challenge code is below, just multiple exceptions to handle
        checked
        {
            try
            {
                int num1 = int.MaxValue;
                int num2 = int.MaxValue;
                int result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
            }
        }

        try
        {
            string? str = null;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            int length = str.Length;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            Console.WriteLine("String Length: " + length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Error: The reference is null. " + ex.Message);
        }

        try
        {
            int[] numbers = new int[5];
            numbers[5] = 10;
            Console.WriteLine("Number at index 5: " + numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: Index out of range. " + ex.Message);
        }

        try
        {
            int num3 = 10;
            int num4 = 0;
            int result2 = num3 / num4;
            Console.WriteLine("Result: " + result2);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
        }

        Console.WriteLine("Exiting program.\n");
    }
}