using System.Runtime.InteropServices;

namespace csharpfoundations;

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
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-1 WriteYourFirstCode module:");
                    WriteYourFirstCode.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-2 LiteralAndVariableValues module:");
                    LiteralAndVariableValues.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-3 BasicStringFormatting module:");
                    BasicStringFormatting.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-4 BasicNumberOperations module:");
                    BasicNumberOperations.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-5-1 CalculateAndPrintStudentGrades module:");
                    CalculateAndPrintStudentGrades.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-5-2 CalculateAndPrintStudentGradesBetter module:");
                    CalculateAndPrintStudentGradesBetter.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-6 CalculateFinalGPA module:");
                    CalculateFinalGPA.Run();

                    break;

                case "2":
                    // Will display all the outputs for the entire second set
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-2 CallMethodsFromDotnetLibrary module:");
                    CallMethodsFromDotnetLibrary.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-3 DecisionLogic module:");
                    DecisionLogic.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-4 StoreAndIterateOverArrays module:");
                    StoreAndIterateOverArrays.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-5 ForeachAndIfElseStructures module:");
                    ForeachAndIfElseStructures.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-6 FurtherForeachAndIfElseStructures module:");
                    FurtherForeachAndIfElseStructures.Run();

                    break;

                case "3":
                    // Displays the entire third set
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-1 EvaluateBooleanExpressions module:");
                    EvaluateBooleanExpressions.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-2 ControlVariableScope module:");
                    ControlVariableScope.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-3 SwitchCaseConstructs module:");
                    SwitchCaseConstructs.Run();

                    break;

                case "1-1":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-1 WriteYourFirstCode module:");
                    WriteYourFirstCode.Run();

                    break;

                case "1-2":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-2 LiteralAndVariableValues module:");
                    LiteralAndVariableValues.Run();

                    break;

                case "1-3":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-3 BasicStringFormatting module:");
                    BasicStringFormatting.Run();

                    break;

                case "1-4":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-4 BasicNumberOperations module:");
                    BasicNumberOperations.Run();

                    break;

                case "1-5-1":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-5-1 CalculateAndPrintStudentGrades module:");
                    CalculateAndPrintStudentGrades.Run();

                    break;

                case "1-5-2":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-5-2 CalculateAndPrintStudentGradesBetter module:");
                    CalculateAndPrintStudentGradesBetter.Run();

                    break;

                case "1-6":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 1-6 CalculateFinalGPA module:");
                    CalculateFinalGPA.Run();

                    break;

                case "2-2":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-2 CallMethodsFromDotnetLibrary module:");
                    CallMethodsFromDotnetLibrary.Run();

                    break;
                
                case "2-3":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-3 DecisionLogic module:");
                    DecisionLogic.Run();

                    break;

                case "2-4":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-4 StoreAndIterateOverArrays module:");
                    StoreAndIterateOverArrays.Run();

                    break;

                case "2-5":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-5 ForeachAndIfElseStructures module:");
                    ForeachAndIfElseStructures.Run();

                    break;

                case "2-6":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 2-6 FurtherForeachAndIfElseStructures module:");
                    FurtherForeachAndIfElseStructures.Run();

                    break;   

                case "3-1":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-1 EvaluateBooleanExpressions module:");
                    EvaluateBooleanExpressions.Run();

                    break;

                case "3-2":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-2 ControlVariableScope module:");
                    ControlVariableScope.Run();

                    break;

                case "3-3":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-3 SwitchCaseConstructs module:");
                    SwitchCaseConstructs.Run();

                    break;

                default:
                    Console.WriteLine($"Invalid argument \"{arg}\"");
                    return;
            }
        }      
    }
}