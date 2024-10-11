using System;
using System.Linq;
using System.Collections.Generic;

class ListsOperations {
    static void Main() {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command = null;
        while ((command = Console.ReadLine()) != "End") {
            string[] commands = command.Split().ToArray();

            switch (commands[0]) {
                case "Add":
                    numbers.Add(int.Parse(commands[1]));
                break;

                case "Insert":
                    if (isValidIndex(numbers, int.Parse(commands[2]))) {
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    }
                    else {
                        Console.WriteLine("Invalid index");
                    }
                break;

                case "Remove":
                    if (isValidIndex(numbers, int.Parse(commands[1]))) {
                        numbers.RemoveAt(int.Parse(commands[1]));
                    }
                    else {
                        Console.WriteLine("Invalid index");
                    }
                break;

                case "Shift":
                    for (int i = 0; i < (int.Parse(commands[2])); i++) {
                        if (commands[1] == "left") {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                        else {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                break;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }

    static bool isValidIndex(List<int> numbers, int indexNumber) {
        return indexNumber < numbers.Count && indexNumber >= 0;
    }
}

