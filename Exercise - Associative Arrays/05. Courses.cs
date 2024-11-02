using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, List<string>> coursesAndRegistratedStudents = new();

        string data = null;
        while ((data = Console.ReadLine()) != "end") {
            string[] arguments = data.Split(" : ").ToArray();

            if (!coursesAndRegistratedStudents.ContainsKey(arguments[0])) {
                coursesAndRegistratedStudents.Add(arguments[0], new List<string>());
            }

            coursesAndRegistratedStudents[arguments[0]].Add(arguments[1]);
        }

        foreach ((string courseName, List<string> courseStudents) in coursesAndRegistratedStudents) {
            Console.WriteLine($"{courseName}: {courseStudents.Count}");

            foreach (string student in courseStudents) {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}