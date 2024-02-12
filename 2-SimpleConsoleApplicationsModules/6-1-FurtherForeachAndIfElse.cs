using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace csharpfoundations;

public class FurtherForeachAndIfElseStructures
{
    public static void Run()
    {
        /*
        This project section will be a replicate of the prior section, but with the extra credit implemented
        It looks like the values need to be sources from the provided code
        The provided code is honestly a bit poor, storing different scores with different purposes in the same array.
        */
        List<BetterProjectStudent> studentList = new();

        studentList.Add(new BetterProjectStudent("Sophia", new int[] {90,86,87,98,100}, new int[] {94, 90}));
        studentList.Add(new BetterProjectStudent("Andrew", new int[] {92,89,81,96,90}, new int[] {89}));
        studentList.Add(new BetterProjectStudent("Emma", new int[] {90,85,87,98,68}, new int[] {89,89,89}));
        studentList.Add(new BetterProjectStudent("Logan", new int[] {90,95,87,88,96}, new int[] {96}));
        studentList.Add(new BetterProjectStudent("Becky", new int[] {92,91,90,91,92}, new int[] {92,92}));
        studentList.Add(new BetterProjectStudent("Chrisropher", new int[] {84,86,88,90,92}, new int[] {94,96,98}));
        studentList.Add(new BetterProjectStudent("Eric", new int[] {80,90,100,80,90}, new int[] {100,80,90}));
        studentList.Add(new BetterProjectStudent("Gregor", new int[] {91,91,91,91,91}, new int[] {91,91}));

        int maxTabs = 0;

        foreach(BetterProjectStudent student in studentList)
        {
            int temp = student.TabLength();
            if(temp > maxTabs) maxTabs = temp;
        }

        string maxTabsString = "";

        for(int i = 0; i < maxTabs; i++) {maxTabsString += "\t";}

        Console.WriteLine($"Student{maxTabsString}Exam Score\tTotal Score\tGrade\tExtra Credit\n");

        foreach(BetterProjectStudent student in studentList) {student.Print(maxTabs);}
    }
}

public class BetterProjectStudent
{
    private List<int> scores = new();
    private List<int> extraCredits = new();
    private string name;

    // Constructors
    public BetterProjectStudent(string studentName) {name = studentName;}

    public BetterProjectStudent(string studentName, int[] studentScores)
    {
        name = studentName;
        foreach (int score in studentScores) scores.Add(score);
    }

    public BetterProjectStudent(string studentName, int[] studentScores, int[] studentExtraCredit)
    {
        name = studentName;
        foreach (int score in studentScores) scores.Add(score);
        foreach (int extra in studentExtraCredit) extraCredits.Add(extra);
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

    public void AddExtraCredit(int newCredit)
    {
        if (0 <= newCredit && newCredit <= 100) extraCredits.Add(newCredit);
        else
        {
            throw new ArgumentOutOfRangeException($"Extra Credit outside of expected range: {newCredit}");
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

    public decimal OverallScore()
    {
        decimal overall = 0;

        foreach(int score in scores)
        {
            overall += score;
        }

        overall += ExtraCreditSum() / 10m;

        overall /= scores.Count;

        return overall;
    }

    public string LetterGrade()
    {
        // Don't love it but have to figure it out somehow
        decimal av = OverallScore();

        // A+ range increased to accomodate a student who gets straight 100s and then does extra credit
        if(97 <= av && av <= 110) return "A+";
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

    public int ExtraCreditSum()
    {
        int extra = 0;

        foreach(int score in extraCredits)
        {
            extra += score;
        }

        return extra;
    }

    public void Print(int tabMax)
    {
        string tabs = "";

        // Make a string to contain the tabs needed
        for (int i = 0; i < tabMax - (name.Length + 1) /8; i++)
        {
            tabs += "\t";
        }

        Console.WriteLine($"{name}:{tabs}{AverageOfScores()}\t\t{OverallScore()}\t\t{LetterGrade()}\t{ExtraCreditSum()/extraCredits.Count} ({(ExtraCreditSum()/10m)/(scores.Count)} pts)");
    }

    public int TabLength() {return (name.Length + 1) / 8 + 1;}
}