using System;
using System.Linq;
using System.Collections.Generic;

internal class Program {
    static void Main() {
        List<string> list = Console.ReadLine().Split(" | ").ToList();

        string commands = "";

        while ((commands = Console.ReadLine()) != "Stop!") {
            string[] arguments = commands.Split();

            switch (arguments[0]) {
                case "Join":
                    if (!list.Contains(arguments[1])) {
                        list.Add(arguments[1]);
                    }
                    break;

                case "Drop":
                    if (list.Contains(arguments[1])) {
                        list.Remove(arguments[1]);
                    }
                    break;

                case "Replace":
                    if (list.Contains(arguments[1]) && !list.Contains(arguments[2])) {
                        list[findIndex(list, arguments[1])] = arguments[2];
                    }
                    break;

                case "Prefer":
                    if (isValidIndex(list, int.Parse(arguments[1])) && isValidIndex(list, int.Parse(arguments[2]))) {
                        string swap = list[int.Parse(arguments[1])];
                        list[int.Parse(arguments[1])] = list[int.Parse(arguments[2])];
                        list[int.Parse(arguments[2])] = swap;
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }


    static bool isValidIndex(List<string> list, int index) {
        return index >= 0 && index < list.Count;
    }

    static int findIndex(List<string> list, string element) {
        int i = 0;
        for (; i < list.Count; i++) {
            if (list[i] == element) {
                break;
            }
        }
        return i;
    }
}