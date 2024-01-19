namespace csharpfoundations
{
    public class Controller
    {
        public static void Main()
        {
            // Made a controller because a console program can't have multiple entry points
            // Well it can but I dont wait to -main my terminal every time
            Console.WriteLine("Below is the output for the WriteYourFirstCode module:");
            WriteYourFirstCode.Run();

            Console.WriteLine("\n\nBelow is the LiteralAndVariableValues module:");
            LiteralAndVariableValues.Run();

            Console.WriteLine("\n\nBelow is the BasicStringFormatting module:");
            BasicStringFormatting.Run();

            Console.WriteLine("\n\nBelow is the BasicStringFormatting module:");
            BasicNumberOperations.Run();
        }
    }
}