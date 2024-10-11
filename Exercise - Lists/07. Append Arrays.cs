using System;
using System.Linq;
using System.Collections.Generic;

class AppendArrays {
    static void Main() {
        string[] line = Console.ReadLine().Split('|').ToArray();  
        List<int> numbers = new List<int>();

        for (int i = line.Length - 1; i >= 0; i--) {
            numbers.AddRange(line[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}


