using System;

class TopNumbers {
    static void Main() {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= number; i++) {
            if (OddDigit(i.ToString()) && isDivisibleByEight(i.ToString())) {
                Console.WriteLine(i);
            }
        }
    }

    static bool OddDigit(string num) {
        foreach (char c in num) {
            if ((c - '0') % 2 != 0) {
                return true;
            }
        }

        return false;
    }

    static bool isDivisibleByEight(string num) {
        int sum = 0;

        foreach (char c in num) {
            sum += c - '0';
        }

        return sum % 8 == 0;
    }
}
