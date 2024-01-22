namespace csharpfoundations
{
    public class WriteYourFirstCode
    {
        public static void Run()
        {
            // Old faithful
            Console.WriteLine("Hello, World!");

            // WriteLine appends /n at the end while Write doesn't
            Console.WriteLine();
            Console.WriteLine("This is the first line.");
            Console.Write("This is the second line.");

            // The below is for readability when using the controller
            Console.WriteLine();
        }
    }
}