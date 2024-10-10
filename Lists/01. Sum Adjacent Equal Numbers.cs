using System;
using System.Linq;
using System.Collections.Generic;

class TopNumbers {
    static void Main() {
        List <int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count - 1; i++) {
            if (numbers[i] == numbers[i + 1]) {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i--;
            }
        }
        
        Console.WriteLine(string.Join(" ", numbers));
    }
}
