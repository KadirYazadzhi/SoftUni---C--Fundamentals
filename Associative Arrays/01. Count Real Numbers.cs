using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        SortedDictionary<double, int> numbersCount = new();

        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++) {
            if (!numbersCount.ContainsKey(numbers[i])) {
                numbersCount.Add(numbers[i], 1);
                continue;
            }

            numbersCount[numbers[i]]++;
        }

        foreach ((double number, int count) in numbersCount) {
            Console.WriteLine($"{number} -> {count}");
        }
    }
}