using System;

class ConvertMetersToKilometers {
    static void Main() {
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine($"{(num / 1000):F2}");
    }
}