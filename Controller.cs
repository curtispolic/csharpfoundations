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

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-4 IterateUsingForStatements module:");
                    IterateUsingForStatements.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-5 LoopingLogicUsingDoWhile module:");
                    LoopingLogicUsingDoWhile.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-6 ConditionalBranchingAndLoopingStructures module:");
                    ConditionalBranchingAndLoopingStructures.Run();

                    break;

                case "4":
                    // Displays the entire fourth set
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-2 CastingAndConversion module:");
                    CastingAndConversions.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-3 ArrayHelperMethods module:");
                    ArrayHelperMethods.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-4 FormattingAlphaNumericData module:");
                    FormattingAlphanumericData.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-5 StringDataTypeMethods module:");
                    StringDataTypeMethods.Run();

                    break;

                case "5":
                    // Display the entire fifth set
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-1 FirstMethod module:");
                    FirstMethod.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-2 MethodsWithParameters module:");
                    MethodsWithParameters.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-3 MethodsWithReturns module:");
                    MethodsWithReturns.Run();

                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-4 PettingZooProject module:");
                    PettingZooProject.Run();

                    break;

                case "6":
                    // Display 6
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 6-3 ExceptionHandling module:");
                    ExceptionHandling.Run();

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

                case "3-4":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-4 IterateUsingForStatements module:");
                    IterateUsingForStatements.Run();

                    break;

                case "3-5":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-5 LoopingLogicUsingDoWhile module:");
                    LoopingLogicUsingDoWhile.Run();

                    break;

                case "3-6":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 3-6 ConditionalBranchingAndLoopingStructures module:");
                    ConditionalBranchingAndLoopingStructures.Run();

                    break;

                case "4-2":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-2 CastingAndConversion module:");
                    CastingAndConversions.Run();

                    break;

                case "4-3":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-3 ArrayHelperMethods module:");
                    ArrayHelperMethods.Run();

                    break;

                case "4-4":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-4 FormattingAlphaNumericData module:");
                    FormattingAlphanumericData.Run();

                    break;

                case "4-5":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 4-5 StringDataTypeMethods module:");
                    StringDataTypeMethods.Run();

                    break;

                case "5-1":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-1 FirstMethod module:");
                    FirstMethod.Run();

                    break;

                case "5-2":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-2 MethodsWithParameters module:");
                    MethodsWithParameters.Run();

                    break;

                case "5-3":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-3 MethodsWithReturns module:");
                    MethodsWithReturns.Run();

                    break;

                case "5-4":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 5-4 PettingZooProject module:");
                    PettingZooProject.Run();

                    break;

                case "6-3":
                    Console.WriteLine("\n--------------------\n\nBelow is the output for the 6-3 ExceptionHandling module:");
                    ExceptionHandling.Run();

                    break;

                default:
                    Console.WriteLine($"Invalid argument \"{arg}\"");
                    return;
            }
        }      
    }
}