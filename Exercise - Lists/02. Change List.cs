using System;
using System.Linq;
using System.Collections.Generic;

class ChangeLists {
    static void Main() {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command = null;
        while ((command = Console.ReadLine()) != "end") {
            string[] commands = command.Split().ToArray();

            if (commands[0] == "Delete") {
                numbers.RemoveAll(n => n == int.Parse(commands[1]));
            }
            else {
                numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
