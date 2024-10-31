using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        List<Students> students = new();

        for (int i = 0; i < num; i++) {
            string[] data = Console.ReadLine().Split().ToArray();
            Students student = new Students(data[0], data[1], data[2]);
            students.Add(student);
        }

        students = students.OrderByDescending(s => s.Grade).ToList();

        foreach (Students s in students) {
            Console.WriteLine($"{s.firstName} {s.lastName}: {s.Grade}");
        }
    }
}

class Students {
    public Students (string FirstName, string LastName, string grade) {
        firstName = FirstName;
        lastName = LastName;
        Grade = grade;
    }

    public string firstName {get; set;}
    public string lastName {get; set;}
    public string Grade {get; set;}
}