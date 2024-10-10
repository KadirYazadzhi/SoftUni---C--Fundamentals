using System;
using System.Linq;
using System.Collections.Generic;

class ListsManipulationAdvanced {
    static void Main() {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        string command;
        bool isChange = false;

        while ((command = Console.ReadLine()) != "end") {
            string[] commandArgs = command.Split();
            string action = commandArgs[0];

            switch (action) {
                case "Contains":
                    Console.WriteLine(numbers.Contains(double.Parse(commandArgs[1])) ? "Yes" : "No such number");
                    break;

                case "PrintEven":
                    printNumbers(numbers, "even");
                    break;

                case "PrintOdd":
                    printNumbers(numbers, "odd");
                    break;

                case "GetSum":
                    Console.WriteLine(countSum(numbers));
                    break;

                case "Filter":
                    filterNumbers(numbers, commandArgs[1], double.Parse(commandArgs[2]));
                    break;

                 case "Add":
                    numbers.Add(double.Parse(commandArgs[1]));
                    isChange = true;
                    break;

                case "Remove":
                    numbers.Remove(double.Parse(commandArgs[1]));
                    isChange = true;
                    break;

                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                    isChange = true;
                    break;

                case "Insert":
                    numbers.Insert(int.Parse(commandArgs[2]), double.Parse(commandArgs[1]));
                    isChange = true;
                    break;
            }
        }

        if (isChange) {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }

    static void printNumbers(List<double> numbers, string evenOrOdd) {
        for (int i = 0; i < numbers.Count; i++) {
            if ((numbers[i] % 2 == 0 && evenOrOdd == "even") || (numbers[i] % 2 != 0 && evenOrOdd == "odd")) {
                Console.Write($"{numbers[i]} ");
            }
        }
        Console.WriteLine();
    }

    static double countSum(List<double> numbers) {
        double sum = 0;
        for (int i = 0; i < numbers.Count; i++) {
            sum += numbers[i];
        }
        return sum;
    }

    static void filterNumbers(List<double> numbers, string operators, double num) {
        for (int i = 0; i < numbers.Count; i++) {
            switch (operators) {
                case ">":
                    if (numbers[i] > num) {
                        Console.Write($"{numbers[i]} ");
                    }
                    break;

                case "<":
                    if (numbers[i] < num) {
                        Console.Write($"{numbers[i]} ");
                    }
                    break;

                case ">=":
                    if (numbers[i] >= num) {
                        Console.Write($"{numbers[i]} ");
                    }
                    break;

                case "<=":
                    if (numbers[i] <= num) {
                        Console.Write($"{numbers[i]} ");
                    }
                    break;
            }
        }
        Console.WriteLine();
    }
}
