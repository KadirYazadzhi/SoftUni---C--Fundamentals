using System;

class Grades {
    static void Main() {
        Console.WriteLine(Grade(double.Parse(Console.ReadLine())));
    }

    static string Grade(double num) {
        string grade = null;
        if (num >= 2.00) {
            grade = "Fail";
        }
        if (num >= 3.00) {
            grade = "Poor";
        }
        if (num >= 3.50) {
           grade = "Good"; 
        }
        if (num >= 4.50) {
            grade = "Very good";
        }
        if (num >= 5.50) {
            grade = "Excellent";
        }

        return grade;
    }
}