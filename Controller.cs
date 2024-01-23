namespace csharpfoundations
{
    public class Controller
    {
        public static void Main(string[] args)
        {
            // Made a controller because a console program can't have multiple entry points
            // Well it can but I dont wait to -main every time

            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "1":
                        // Will display all the outputs for the entire first set
                        Console.WriteLine("\n--------------------\n\nBelow is the output for the WriteYourFirstCode module:");
                        WriteYourFirstCode.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the LiteralAndVariableValues module:");
                        LiteralAndVariableValues.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the BasicStringFormatting module:");
                        BasicStringFormatting.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the BasicNumberOperations module:");
                        BasicNumberOperations.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the CalculateAndPrintStudentGrades module:");
                        CalculateAndPrintStudentGrades.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the CalculateAndPrintStudentGradesBetter module:");
                        CalculateAndPrintStudentGradesBetter.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the CalculateFinalGPA module:");
                        CalculateFinalGPA.Run();

                        break;

                    case "2":
                        // Will display all the outputs for the entire second set
                        Console.WriteLine("\n--------------------\n\nBelow is the output for the CallMethodsFromDotnetLibrary module:");
                        CallMethodsFromDotnetLibrary.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the DecisionLogic module:");
                        DecisionLogic.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the StoreAndIterateOverArrays module:");
                        StoreAndIterateOverArrays.Run();

                        Console.WriteLine("\n--------------------\n\nBelow is the output for the ForeachAndIfElseStructures module:");
                        ForeachAndIfElseStructures.Run();

                        break;

                    default:
                        Console.WriteLine($"Invalid argument \"{arg}\"");
                        return;
                }
            }      
        }
    }
}