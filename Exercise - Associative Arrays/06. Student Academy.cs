using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, List<double>> studentsGrades = new();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++) {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!studentsGrades.ContainsKey(name)) {
                studentsGrades.Add(name, new List<double>());
            }

            studentsGrades[name].Add(grade);
        }

        studentsGrades = studentsGrades
            .Where(s => s.Value.Average() >= 4.50)
            .ToDictionary(s => s.Key, s => s.Value);

        foreach ((string student, List<double> grades) in studentsGrades) {
            Console.WriteLine($"{student} -> {grades.Average():F2}");
        }
    }
}