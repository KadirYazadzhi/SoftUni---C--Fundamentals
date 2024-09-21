using System;

class SpecialNumbers {
    static void Main() {
        int numbers = int.Parse(Console.ReadLine());

        for (int num = 1; num <= numbers; num++) {
            int currentNum = num;
            int sum = 0;

            while (currentNum > 0) {
                sum += currentNum % 10;
                currentNum /= 10;
            }

            if (sum == 5 || sum == 7 || sum == 11) {
                Console.WriteLine($"{num} -> True");
            }
            else {
                Console.WriteLine($"{num} -> False"); 
            }
        }
    }
}