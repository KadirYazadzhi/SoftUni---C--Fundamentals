using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> words = Console.ReadLine().Split().Where(word => word.Length % 2 == 0).ToList();

        foreach (string word in words) {
            Console.WriteLine(word);
        }
    }
}