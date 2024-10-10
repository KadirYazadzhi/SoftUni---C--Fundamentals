using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNegativesAndReverse {
    static void Main() {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        numbers.RemoveAll(n => n < 0);

        if (numbers.Count <= 0) {
            Console.WriteLine("empty");
            return;
        }

        numbers.Reverse();
        Console.WriteLine(string.Join(" ", numbers));
    }
}