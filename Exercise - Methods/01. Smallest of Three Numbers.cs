using System;
using System.Linq;

class SmallestOfThreeNumbers {
    static void Main() {
        Console.WriteLine(smallestNumbers());
    }

    static int smallestNumbers() {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++) {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int minNumber = 2147483647;
        foreach (int num in numbers) {
            if (num < minNumber) {
                minNumber = num;
            }
        }
        return minNumber;
    }
}
