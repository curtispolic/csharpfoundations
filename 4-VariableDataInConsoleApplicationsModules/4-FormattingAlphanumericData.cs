namespace csharpfoundations;

public class FormattingAlphanumericData
{
    public static void Run()
    {
        // Composite formatting
        string first = "Hello";
        string second = "World";
        Console.WriteLine("{1} {0}!", first, second);
        Console.WriteLine("{0} {0} {0}!", first, second);

        // String interpolation
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");

        // Formatting currency, this adapts to windows display language
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        // N uses commas to separate, followed by a number of decimal points (default 2)
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N4} units");

        // P uses percentages with number of decimal points
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");

        // "Exercise" but it tells you every step?
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {total:C}");

        // Padding, by default is whitespace but can overload a char as 2nd argument
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));
        Console.WriteLine(input.PadRight(12));

        Console.WriteLine(input.PadLeft(12, '-'));
        Console.WriteLine(input.PadRight(12, '-'));

        // Can be seen well here
        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);

        // Challenge is to output an automated email
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        // Your logic here
        Console.WriteLine($"Dear {customerName}");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
        Console.WriteLine();
        Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.");
        Console.WriteLine();
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.");
        Console.WriteLine();
        Console.WriteLine("Here's a quick comparison:\n");

        // Your logic here
        Console.WriteLine($"{currentProduct.PadRight(20)}{currentReturn:P}\t{currentProfit:C}");
        Console.WriteLine($"{newProduct.PadRight(20)}{newReturn:P}\t{newProfit:C}");
    }
}