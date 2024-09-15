using System;

class SumOfOddNumbers {
    static void Main() {
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i < num * 2; i++) {
            if (i % 2 != 0) {
                Console.WriteLine(i);
                sum += i;
            }
        }
        Console.WriteLine($"Sum: {sum}");
    }
}