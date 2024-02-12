namespace csharpfoundations;

public class BasicStringFormatting
{
    public static void Run()
    {
        // Showing \n and \t escape character sequences
        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("Hello\tWorld");

        // Escape some ""s
        Console.WriteLine("Hello \"World\"");

        // Escape \
        Console.WriteLine("c:\\source\\repos");
        // A bit wrong writing that on a Mac

        // @ denotes a verbatim string literal
        Console.WriteLine(@"      /Users/polic.c/Projects/csharpfoundations/
(this is where my code goes!)");
        // Doesn't feel as wrong

        // Unicode characters
        Console.WriteLine("\u65e5\u672c\u306e");

        // Ahaha now it's teaching me concatenation
        string firstName = "Bob";
        string message = "Hello";

        Console.WriteLine(message + " " + firstName);

        // It also says not to store the concatenation and do it when requred
        // Makes sense from a memory perspective

        // String interpolation
        string interpolationExample = $"{message} {firstName}, I am learning C#";
        Console.WriteLine(interpolationExample);

        // Of course I should be doing it like so:
        Console.WriteLine($"{message} {firstName}, I'm using good coding practices");

        // Combine verbatim and interpolation
        Console.WriteLine($@"/Users/{firstName}/Desktop/");


        // Code for the challenge is below:
        /* Must produce the following output:
            View English output:
                c:\Exercise\ACME\data.txt

            Посмотреть русский вывод:
                c:\Exercise\ACME\ru-RU\data.txt
        */
        // I'm provided the below variables:

        string projectName = "ACME";

        // I broke this one down for readability
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440" +
            "\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 " +
            "\u0432\u044b\u0432\u043e\u0434";

        // English
        Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt");

        Console.WriteLine();

        // Russian
        Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");


    }
}