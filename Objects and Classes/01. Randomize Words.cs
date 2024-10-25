using System;
using System.Linq;
using System.Collections.Generic;

class RandomizeWords {
    static void Main() {
        List<string> words = Console.ReadLine().Split().ToList();
        Random random = new Random();

        for (int i = 0; i < words.Count; i++) {
            int index = random.Next(words.Count);
            string word = words[index];
            words[index] = words[i];
            words[i] = word;
        }

        foreach (string word in words) {
            Console.WriteLine(word);
        }
    }
}