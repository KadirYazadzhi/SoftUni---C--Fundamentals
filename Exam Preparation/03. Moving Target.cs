using System;
using System.Linq;
using System.Collections.Generic;

class MovingTarget {
    static void Main() {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command = null;
        while ((command = Console.ReadLine()) != "End") {
            string[] commands = command.Split().ToArray();

            switch (commands[0]) {
                case "Shoot":
                    numbers = ShootTarget(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                break;

                case "Add":
                    numbers = InsertValue(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                break;

                case "Strike":
                    numbers = StrikeTarget(numbers, int.Parse(commands[1]), int.Parse(commands[2]));
                break;
            }
        }
        Console.WriteLine(string.Join("|", numbers));
    }

    static List<int> ShootTarget(List<int> numbers, int index, int power) {
        if (index >= 0 && index < numbers.Count) {
            numbers[index] -= power;

            if (numbers[index] <= 0) {
                numbers.RemoveAt(index);
            }
        }
        return numbers;
    }

    
    static List<int> InsertValue(List<int> numbers, int index, int value) {
        if (index >= 0 && index < numbers.Count) {
            numbers.Insert(index, value);
        }
        else {
            Console.WriteLine("Invalid placement!");
        }
        return numbers;
    }

    static List<int> StrikeTarget(List<int> numbers, int index, int radius) {
        if (index - radius >= 0 && index + radius < numbers.Count) {
            for (int i = 0; i < radius * 2 + 1; i++) {
                numbers.RemoveAt(index - radius);
            }
        }
        else {
            Console.WriteLine("Strike missed!");
        }
        return numbers;
    }
}
