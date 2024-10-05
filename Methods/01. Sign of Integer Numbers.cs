using System;

class SignOfIntegerNumbers {
    static void Main() {
        SignOfTheNumber(int.Parse(Console.ReadLine()));
    }

    static void SignOfTheNumber(int  num) {
        if (num > 0) {
            Console.WriteLine($"The number {num} is positive.");
        }
        else if (num < 0) {
            Console.WriteLine($"The number {num} is negative.");
        }
        else {
           Console.WriteLine($"The number {num} is zero."); 
        }
    }
}