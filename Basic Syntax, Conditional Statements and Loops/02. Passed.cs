using System;

class Passed {
    static void Main() {
        double num = double.Parse(Console.ReadLine());
        if (num >= 3.00) {
            Console.WriteLine("Passed!");
        }
    }
}