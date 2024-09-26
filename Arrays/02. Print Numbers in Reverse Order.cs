using System;

class PrintInReverseOrder {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int number = 0;

        for (int i = 0; i < n; i++) {
            number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }

        for (int i = 0; i < numbers.Length; i++) {
            Console.Write(numbers[n - i - 1] + " ");
        }
    }
}