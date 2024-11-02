using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, List<string>> wordsSynonyms = new();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!wordsSynonyms.ContainsKey(word)) {
                wordsSynonyms.Add(word, new List<string>());
            }

            wordsSynonyms[word].Add(synonym);
        }

        foreach ((string word, List<string> synonyms) in wordsSynonyms) {
            Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
        }
    }
}