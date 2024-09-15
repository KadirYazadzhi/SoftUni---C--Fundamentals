using System;

class EvenNumber {
    static void Main() {
        while(true) {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                if (num < 0) {
                    num *= -1;
                }
                Console.WriteLine($"The number is: {num}");
                break;
            }
            else {
                Console.WriteLine("Please write an even number.");
            }
        }
    }
}