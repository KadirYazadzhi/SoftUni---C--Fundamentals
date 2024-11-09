using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        List<string> words = Console.ReadLine().Split(' ').ToList();

        foreach (string word in words) {
            Repeating(word);
        }
    }

    public static void Repeating(string word) {
        for (int i = 0; i < word.Length; i++) {
            Console.Write(word);
        }
    }
}

