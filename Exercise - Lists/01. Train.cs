using System;
using System.Linq;
using System.Collections.Generic;

class Train {
    static void Main() {
        List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());

        string command = null;
        while ((command = Console.ReadLine()) != "end") {
            string[] commands = command.Split().ToArray();

            if (commands[0] == "Add") {
                train.Add(int.Parse(commands[1]));
            }
            else {
                for (int i = 0; i < train.Count; i++) {
                    if (train[i] + (int.Parse(commands[0])) <= maxCapacity) {
                        train[i] += (int.Parse(commands[0]));
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", train));
    }
}
