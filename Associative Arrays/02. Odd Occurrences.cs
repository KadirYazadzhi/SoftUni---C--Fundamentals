using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, int> wordsCount = new();

        string[] words = Console.ReadLine().Split().ToArray();
        for (int i = 0; i < words.Length; i++) {
            if (!wordsCount.ContainsKey(words[i].ToLower())) {
                wordsCount.Add(words[i].ToLower(), 1);
                continue;
            }

            wordsCount[words[i].ToLower()]++;
        }

        foreach ((string word, int count) in wordsCount) {
            if (count % 2 != 0) {
                Console.Write($"{word} ");
            }
        }
    }
}