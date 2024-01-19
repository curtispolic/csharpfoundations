namespace csharpfoundations
{
	public class CalculateFinalGPA
	{
        public static void Run()
        {
            // It's happening again :(
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Hours = 3;
            int course2Hours = 3;
            int course3Hours = 4;
            int course4Hours = 4;
            int course5Hours = 3;

            // Took me a moment to find the c# equivalent of Java's final
            // They aren't exactly equivalent but for this purpose they are
            /*
            int gradeA = 4;
            int gradeB = 3;
            */

            const int gradeA = 4;
            const int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int creditHoursTotal = 0;
            creditHoursTotal += course1Hours;
            creditHoursTotal += course2Hours;
            creditHoursTotal += course3Hours;
            creditHoursTotal += course4Hours;
            creditHoursTotal += course5Hours;

            int totalGradePoints = 0;
            totalGradePoints += course1Hours * course1Grade;
            totalGradePoints += course2Hours * course2Grade;
            totalGradePoints += course3Hours * course3Grade;
            totalGradePoints += course4Hours * course4Grade;
            totalGradePoints += course5Hours * course5Grade;

            decimal gradePointAverage = (decimal)totalGradePoints / creditHoursTotal;

            // I hate this recommended solution
            /*
            int leadingDigit = (int)gradePointAverage;
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;
            */

            // Yes it's a bit hacky but it's the exact same
            decimal betterSolution = (int)(gradePointAverage * 100) / 100m;

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Hours}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Hours}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Hours}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Hours}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Hours}");

            // Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
            Console.WriteLine($"\nFinal GPA:\t\t\t{betterSolution}");

            // If I'd known this module was the same I'd have contained myself in module 5
            // This one could use a more elegant solution as well
        }
	}
}

