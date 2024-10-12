using System;
using System.Linq;
using System.Collections.Generic;

internal class Program {
    static void Main() {
        List<string> list = Console.ReadLine().Split().ToList();

        string commands = "";

        while ((commands = Console.ReadLine()) != "3:1") {
            string[] arguments = commands.Split();

            switch (arguments[0]) {
                case "merge":
                    list = Merge(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                    break;
                case "divide":
                    list = Divide(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }

    static List<string> Merge(List<string> list, int startIndex, int endIndex) {
        startIndex = Clamp(startIndex, 0, list.Count);
        endIndex = Clamp(endIndex, 0, list.Count - 1);

        string merged = string.Join("", list.GetRange(startIndex, endIndex - startIndex + 1));
        list.RemoveRange(startIndex, endIndex - startIndex + 1);
        list.Insert(startIndex, merged);

        return list;
    }

    private static List<string> Divide(List<string> list, int index, int partitions) {
        string element = list[index];

        if (partitions <= 0)
        {
            return list;
        }

        list.RemoveRange(index, 1);
        int subLength = element.Length / partitions;
        int remainingChars = element.Length % partitions;

        List<string> newElements = new List<string>();

        int elementIndex = 0;
        for (int i = 0; i < partitions; i++) {
            string newString = "";
            for (int j = 0; j < subLength; j++) {
                newString += element[elementIndex];
                elementIndex++;
            }

            newElements.Add(newString);
        }

        if (remainingChars > 0 && newElements.Count > 0) {
            for (int i = elementIndex; i < element.Length; i++) {
                newElements[newElements.Count - 1] += element[i];
            }
        }

        list.InsertRange(index, newElements);

        return list;
    }

    private static int Clamp(int value, int min, int max) {
        if (value < min) {
            value = min;
        }
        else if (value > max) {
            value = max;
        }

        return value;
    }
}