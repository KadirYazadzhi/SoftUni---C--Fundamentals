using System;
using System.Linq;

class SumAndOddEvenNumbers {
    static void Main() {
        int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sumEven = 0;
        int sumOdd = 0;

        foreach (int num in numbers) {
            if (num % 2 == 0) {
                sumEven += num;
            }
            else {
                sumOdd += num; 
            }
        }
        Console.WriteLine(sumEven - sumOdd);
    }
}