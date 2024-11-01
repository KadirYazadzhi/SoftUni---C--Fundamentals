using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main() {
        List<Person> persons = new();

        string data;
        while ((data = Console.ReadLine()) != "End") {
            string[] arguments = data.Split();

            Person existingPerson = persons.FirstOrDefault(p => p.Id == arguments[1]);
            if (existingPerson != null) {
                existingPerson.Name = arguments[0];
                existingPerson.Age = int.Parse(arguments[2]);
            } 
            else {
                persons.Add(new Person(arguments[0], arguments[1], int.Parse(arguments[2])));
            }
        }

        persons = persons.OrderBy(p => p.Age).ToList();

        foreach (Person p in persons) {
            Console.WriteLine($"{p.Name} with ID: {p.Id} is {p.Age} years old.");
        }
    }
}

class Person {
    public Person(string name, string id, int age) {
        Name = name;
        Id = id;
        Age = age;
    }

    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }
}
