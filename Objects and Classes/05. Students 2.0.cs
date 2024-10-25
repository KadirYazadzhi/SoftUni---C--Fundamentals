using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<Student> students = new();

        string data;
        while ((data = Console.ReadLine()) != "end") {
            string[] studentsInfo = data.Split().ToArray();

            if (isStudentExist(students, studentsInfo[0], studentsInfo[1])) {
                Student studentToChange = GetStudent(students, studentsInfo[0], studentsInfo[1]);
                studentToChange.age = int.Parse(studentsInfo[2]);
                studentToChange.town = studentsInfo[3];
                continue; 
            }

            Student student = new Student(studentsInfo[0], studentsInfo[1], int.Parse(studentsInfo[2]), studentsInfo[3]);
            students.Add(student);
        }

        string townToPrint = Console.ReadLine();
        foreach (Student s in students) {
            if (s.town == townToPrint) {
                Console.WriteLine($"{s.firstName} {s.lastName} is {s.age} years old.");
            }
        }
    }

    static bool isStudentExist(List<Student> students, string firstName, string lastName) {
        foreach (Student student in students) {
            if (student.firstName == firstName && student.lastName == lastName) {
                return true;
            }
        }

        return false;
    }

    static Student GetStudent(List<Student> students, string firstName, string lastName) {
        foreach (Student student in students) {
            if (student.firstName == firstName && student.lastName == lastName) {
                return student; 
            }
        }
        return null; 
    }
}

class Student {
    public Student(string FirstName, string LastName, int Age, string Town) {
        firstName = FirstName;
        lastName = LastName;
        age = Age;
        town = Town;
    }

    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string town { get; set; }
}
