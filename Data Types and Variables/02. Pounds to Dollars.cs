using System;

class PoundToDolar {
    static void Main() {
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine($"{(num * 1.31):F3}");
    }
}