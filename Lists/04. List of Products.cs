using System;
using System.Linq;
using System.Collections.Generic;

class ListOfProducts {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        for (int i = 0; i < n; i++) {
            words.Add(Console.ReadLine());
        }

        words.Sort();

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"{i + 1}.{words[i]}");
        }
    }
}