using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<char, int> charsCount = new();

        string line = Console.ReadLine();

        for (int i = 0; i < line.Length; i++) {
            if (line[i] == ' ') {
                continue;
            }
            if (!charsCount.ContainsKey(line[i])) {
                charsCount.Add(line[i], 1);
                continue;
            }
            charsCount[line[i]]++;
        }

        foreach ((char character, int count) in charsCount) {
            Console.WriteLine($"{character} -> {count}");
        }
    }
}