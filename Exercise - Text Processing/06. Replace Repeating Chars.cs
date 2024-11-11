using System;
using System.Text;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<char> input = Console.ReadLine().ToCharArray().ToList();
        List<char> output = new List<char>();

        if (input.Count > 0) {
            output.Add(input[0]);
        }
        
        for (int i = 1; i < input.Count; i++) {
            if (input[i] != input[i - 1]) {
                output.Add(input[i]);
            }
        }
        
        Console.WriteLine(new string(output.ToArray()));
    }
}
