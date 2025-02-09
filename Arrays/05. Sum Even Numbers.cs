using System;
using System.Linq;

class SumEvenNumbers {
    static void Main() {
        int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sum = 0;

        foreach (int num in numbers) {
            if (num % 2 == 0) {
                sum += num;
            }
        }
        Console.WriteLine(sum);
    }
}