using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace csharpfoundations;

public class ForeachAndIfElseStructures
{
    public static void Run()
    {
        /*
        The project has the following requirements:
        Start with four students. Each student has five exam scores.

        Each exam score is an integer value, 0-100, where 100 represents 100% correct.

        A student's overall exam score is the average of their five exam scores.

        Criteria for extra credit assignments:

        Include extra credit assignment scores in the student's scores array.
            Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
            Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
            Your application needs to automatically assign letter grades based on the calculated final score for each student.
        Extra credit will be implemented in the next module

        Your application needs to output/display each student’s name and formatted grade.

        Your application needs to support adding other students and scores with minimal impact to the code.

        The original provided code for the project is in 5-2-ProvidedCode
        */
        List<ProjectStudent> studentList = new();

        ProjectStudent sophia = new ProjectStudent("Sophia", new int[] {90,86,87,98,100});
        studentList.Add(sophia);

        ProjectStudent andrew = new ProjectStudent("Andrew", new int[] {92,89,81,96,90});
        studentList.Add(andrew);

        ProjectStudent emma = new ProjectStudent("Emma", new int[] {90,85,87,98,68});
        studentList.Add(emma);

        ProjectStudent logan = new ProjectStudent("Logan", new int[] {90,95,87,88,96});
        studentList.Add(logan);

        // I would normally do this like so: studentList.Add(new ProjectStudent("Logan", new int[] {90,95,87,88,96}); for memory conservation purposes
        // Did so differently above for readability purposes

        int maxTabs = 0;

        foreach(ProjectStudent student in studentList)
        {
            int temp = student.TabLength();
            if(temp > maxTabs) maxTabs = temp;
        }

        string maxTabsString = "";

        for(int i = 0; i < maxTabs; i++) {maxTabsString += "\t";}

        Console.WriteLine($"Student{maxTabsString}Grade\n");

        foreach(ProjectStudent student in studentList) {student.Print(maxTabs);}
    }
}

public class ProjectStudent
{
    private List<int> scores = new();
    private string name;

    // Constructors
    public ProjectStudent(string studentName) {name = studentName;}

    public ProjectStudent(string studentName, int[] studentScores)
    {
        name = studentName;
        foreach (int score in studentScores) scores.Add(score);
    }

    public void AddScore(int newScore)
    {
        // Appends to the score list
        if(0 <= newScore && newScore <= 100) scores.Add(newScore);
        else
        {
            throw new ArgumentOutOfRangeException($"Score outside of expected range: {newScore}");
        }
    }

    public decimal AverageOfScores()
    {
        // Sums all the scores and divides by the total
        decimal total = 0;
        foreach (int score in scores)
        {
            total += score;
        }
        return total / scores.Count;
    }

    public string LetterGrade()
    {
        // Don't love it but have to figure it out somehow
        decimal av = AverageOfScores();
        if(97 <= av && av <= 100) return "A+";
        else if(93 <= av && av < 97) return "A";
        else if(90 <= av && av < 93) return "A-";
        else if(87 <= av && av < 90) return "B+";
        else if(83 <= av && av < 87) return "B";
        else if(80 <= av && av < 83) return "B-";
        else if(77 <= av && av < 80) return "C+";
        else if(73 <= av && av < 77) return "C";
        else if(70 <= av && av < 73) return "C-";
        else if(67 <= av && av < 70) return "D+";
        else if(63 <= av && av < 67) return "D";
        else if(60 <= av && av < 63) return "D-";
        else if(0 <= av && av < 60) return "F";
        else
        {
            // Big issues if it's outside of this
            throw new ArgumentOutOfRangeException($"Average of scores falls out of expect range: {av}");
        }
    }

    public void Print(int tabMax)
    {
        string tabs = "";

        // Make a string to contain the tabs needed
        for (int i = 0; i < tabMax - (name.Length + 1) /8; i++)
        {
            tabs += "\t";
        }

        Console.WriteLine($"{name}:{tabs}{AverageOfScores()}\t{LetterGrade()}");
    }

    public int TabLength() {return (name.Length + 1) / 8 + 1;}
}