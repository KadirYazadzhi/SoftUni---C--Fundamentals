using System;
using System.Linq;
using System.Collections.Generic;

class GaussTrick {
    static void Main() {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        for (int i = 0; i < numbers.Count - 1; i++) {
            numbers[i] = numbers[i] + numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}