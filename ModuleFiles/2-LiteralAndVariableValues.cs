namespace csharpfoundations
{
    public class LiteralAndVariableValues
    {
        public static void Run()
        {
            // char literal, can only be one character
            Console.WriteLine('b');

            // Already seen string literals
            Console.WriteLine("String");

            // Integer, Float (F suffix), Double (m suffix), Booleans (all lower in C#)
            Console.WriteLine(123);
            Console.WriteLine(0.25F);
            Console.WriteLine(12.11234m);
            Console.WriteLine(true);

            // Doubles are the default when giving a decimal value

            // Variable declaration practic

            string firstName;

            int gameScore = 12;

            var message = "Message example";

            // vars are typed by implication of the data entered
            // They must be assigned a value when they are initialised

            // "Bob" = firstName will error because variable must be on left hand side
            // This is also morally wrong

            Console.WriteLine(gameScore);
            // As you'd expect

            // Below is the code for the challenge
            // Must display the following: "Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius."

            // I figure the idea is to use variables and not verbatim the message

            string challengeName = "Bob";
            int messageTotal = 3;
            double temperatureCelsius = 34.4;

            Console.WriteLine("\nHello, " + challengeName + "! You have " +
                messageTotal.ToString() + " messages in your inbox. The temperature is " +
                temperatureCelsius.ToString() + "celsius");
        }
    }
}