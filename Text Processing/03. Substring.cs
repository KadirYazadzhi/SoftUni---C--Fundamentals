using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        string wordToRemove = Console.ReadLine();
        string line = Console.ReadLine();

        while (true) {
            if (line.Contains(wordToRemove)) {
                line = line.Remove(line.IndexOf(wordToRemove), wordToRemove.Length);
                continue;
            }
            break;
        }
        Console.WriteLine(line);
    }
}
