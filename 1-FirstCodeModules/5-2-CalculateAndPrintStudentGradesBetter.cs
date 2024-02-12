namespace csharpfoundations;

public class CalculateAndPrintStudentGradesBetter
{
    public static void Run()
    {
        // I think this is a much cleaner solution
        // Provided variables (I'm an array enjoyer):
        int currentAssignments = 5;

        int[] sophiaScores = { 93, 87, 98, 95, 100 };
        int[] nicolasScores = { 80, 83, 82, 88, 85 };
        int[] zahirahScores = { 84, 96, 73, 85, 79 };
        int[] jeongScores = { 90, 92, 98, 100, 97 };

        // Array the names
        string[] students = { "Sophia", "Nicolas", "Zahirah", "Jeong" };

        // Array all the scores
        int[][] studentScores = { sophiaScores, nicolasScores, zahirahScores, jeongScores };

        // Array the sums, letter grades, and averages
        int[] studentTotals = { 0, 0, 0, 0 };
        decimal[] studentAverages = { 0, 0, 0, 0 };
        char[] studentLetterGrades = { 'Z', 'Z', 'Z', 'Z' };

        // index to increment for array accessing
        int index = 0;

        // Determine how many tabs each name will need
        // Tab length in C# console is 8 characters
        int maxTabLength = 0;

        foreach (string name in students)
        {
            int temp = (name.Length + 1) / 8 + 1;
            if (temp > maxTabLength) maxTabLength = temp;
        }

        // Print the header of the "table"
        Console.WriteLine("Student\t\tGrade\n");

        // Looping over the array and getting all the data
        foreach (int[] scoreArray in studentScores)
        {
            foreach (int score in scoreArray)
            {
                studentTotals[index] += score;
            }
            studentAverages[index] = (decimal)studentTotals[index] / currentAssignments;

            // Switch for letter grades (I don't remember them I just made them up)
            switch(studentAverages[index])
            {
                case > 90:
                    studentLetterGrades[index] = 'A';
                    break;
                case > 80:
                    studentLetterGrades[index] = 'B';
                    break;
                case > 70:
                    studentLetterGrades[index] = 'C';
                    break;
                case > 60:
                    studentLetterGrades[index] = 'D';
                    break;
                default:
                    studentLetterGrades[index] = 'F';
                    break;
            }

            // It'll make sense
            string tabs = "";

            // Make a string to contain the tabs needed
            for (int i = 0; i < maxTabLength - (students[index].Length + 1) /8; i++)
            {
                tabs += "\t";
            }

            // Print it all out
            Console.WriteLine($"{students[index]}:{tabs}{studentAverages[index]}\t{studentLetterGrades[index]}");

            // Never forget
            index++;
        }
    }
}