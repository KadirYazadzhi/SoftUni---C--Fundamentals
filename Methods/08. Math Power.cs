using System;

class MathPower {
    static void Main() {
        Console.WriteLine(MathPowerSum(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    static double MathPowerSum(double num1, double num2) {
        return Math.Pow(num1, num2);
    }
}