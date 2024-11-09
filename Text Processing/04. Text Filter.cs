using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        List<string> wordsToRemove = Console.ReadLine().Split(", ").ToList();
        string line = Console.ReadLine();

        foreach (string word in wordsToRemove) {
            if (line.Contains(word)) {
                line = line.Replace(word, new string('*', word.Length));
            }
        }
        
        Console.WriteLine(line);
    }
}
