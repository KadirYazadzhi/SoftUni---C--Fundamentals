using System;
using System.Linq;
using System.Collections.Generic;

internal class Program {
    static void Main() {
        List<string> list = Console.ReadLine().Split(", ").ToList();

        string commands = "";

        while ((commands = Console.ReadLine()) != "Report") {
            string[] arguments = commands.Split();

            switch (arguments[0]) {
                case "Blacklist":
                    list = Blacklist(list, arguments[1]);
                    break;

                case "Error":
                    list = Error(list, int.Parse(arguments[1]));
                    break;

                case "Change":
                    list = Change(list, int.Parse(arguments[1]), arguments[2]);
                    break;
            }
        }

        BlacklistedAndLostName(list);
        Console.WriteLine(string.Join(" ", list));
    }

    static List<string> Blacklist(List<string> list, string name) {
            if (list.Contains(name)) {
                for (int i = 0; i < list.Count; i++) {
                    if (list[i] == name) {
                        list[i] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                        break;
                    }
                }
            }
            else {
                Console.WriteLine($"{name} was not found.");
            }

            return list;
        }

    static List<string> Error(List<string> list, int index) {
        if (isValidIndex(list, index) && list[index] != "Blacklisted" && list[index] != "Lost") {
            Console.WriteLine($"{list[index]} was lost due to an error.");
            list[index] = "Lost";
        }

        return list;
    }

    static List<string> Change(List<string> list, int index, string newName) {
        if (isValidIndex(list, index) && list[index] != "Blacklisted" && list[index] != "Lost") {
            Console.WriteLine($"{list[index]} changed his username to {newName}.");
            list[index] = newName;
        }

        return list;
    }

    static void BlacklistedAndLostName(List<string> list) {
        int blacklisted = 0;
        int lost = 0;

        foreach (string name in list) {
            if (name == "Blacklisted") {
                blacklisted++;
            }
            if (name == "Lost") {
                lost++;
            }
        }

        Console.WriteLine($"Blacklisted names: {blacklisted}");
        Console.WriteLine($"Lost names: {lost}");
    }

    static bool isValidIndex(List<string> list, int index) {
        return index >= 0 && index < list.Count;
    }

}