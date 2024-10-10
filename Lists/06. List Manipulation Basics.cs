using System;
using System.Linq;
using System.Collections.Generic;

class ListsManipulationBasics {
    static void Main() {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        string command;

        while ((command = Console.ReadLine()) != "end") {
            string[] commandArgs = command.Split();
            string action = commandArgs[0];

            switch (action) {
                case "Add":
                    numbers.Add(double.Parse(commandArgs[1]));
                    break;

                case "Remove":
                    numbers.Remove(double.Parse(commandArgs[1]));
                    break;

                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                    break;

                case "Insert":
                    numbers.Insert(int.Parse(commandArgs[2]), double.Parse(commandArgs[1]));
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
