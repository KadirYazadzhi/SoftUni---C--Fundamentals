using System;
using System.Linq;
using System.Collections.Generic;

class SumAdjacentEqualNumbers {
    static void Main() {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        for (int i = 0; i < numbers.Count - 1; ) {
            if (numbers[i] == numbers[i + 1]) {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = 0;
            }
            else {
                i++;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
