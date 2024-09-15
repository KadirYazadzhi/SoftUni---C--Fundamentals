using System;

class PassedOrFailed {
    static void Main() {
        double num = double.Parse(Console.ReadLine());
        if (num >= 3.00) {
            Console.WriteLine("Passed!");
        }
        else {
            Console.WriteLine("Failed!");
        }
    }
}