using System;

class MultipleEvensByOdds {
    static void Main() {
        Console.WriteLine(multipleEvenByOdd(Console.ReadLine()));
    }

    static int multipleEvenByOdd(string numbers) {
        int sumOdd = 0;
        int sumEven = 0;

        foreach (char c in numbers) {
            if (c != '-') {
                int num = c - '0';

                if (num % 2 == 0) {
                    sumEven += num;
                }
                else {
                    sumOdd += num;
                }
            }
        }

        return sumEven * sumOdd;
    }
}