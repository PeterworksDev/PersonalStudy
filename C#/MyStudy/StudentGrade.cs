//Module : https://learn.microsoft.com/ko-kr/training/modules/guided-project-calculate-print-student-grades/

namespace MyStudy;

public class StudentGrade
{
    int currentAssignments = 5;

    int sophia1 = 93;
    int sophia2 = 87;
    int sophia3 = 98;
    int sophia4 = 95;
    int sophia5 = 100;
    int sophiaSum = 0;
    decimal sophiaScore = 0;

    int nicolas1 = 80;
    int nicolas2 = 83;
    int nicolas3 = 82;
    int nicolas4 = 88;
    int nicolas5 = 85;
    int nicolasSum = 0;
    decimal nicolasScore = 0;


    int zahirah1 = 84;
    int zahirah2 = 96;
    int zahirah3 = 73;
    int zahirah4 = 85;
    int zahirah5 = 79;
    int zahirahSum = 0;
    decimal zahirahScore = 0;

    int jeong1 = 90;
    int jeong2 = 92;
    int jeong3 = 98;
    int jeong4 = 100;
    int jeong5 = 97;
    int jeongSum = 0;
    decimal jeongScore = 0;

    public void calculateStudentGrades()
    {
        sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        sophiaScore = calculateScore(sophiaSum, currentAssignments);
        nicolasScore = calculateScore(nicolasSum, currentAssignments);
        zahirahScore = calculateScore(zahirahSum, currentAssignments);
        jeongScore = calculateScore(jeongSum, currentAssignments);

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore +"\t"+ determineGrade(sophiaScore));
        Console.WriteLine("Nicolas:\t" + nicolasScore +"\t"+ determineGrade(nicolasScore));
        Console.WriteLine("Zahirah:\t" + zahirahScore +"\t"+ determineGrade(zahirahScore));
        Console.WriteLine("Jeong:\t\t" + jeongScore +"\t"+ determineGrade(jeongScore));
    }

    public decimal calculateScore(int totalSum, int currentAssignments)
    {
        decimal score = (decimal)totalSum / currentAssignments;

        return score;
    }
    
    public string determineGrade(decimal score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }



}