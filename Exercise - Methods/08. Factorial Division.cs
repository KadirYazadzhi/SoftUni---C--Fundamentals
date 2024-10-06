using System;

class FactorialDivision {
    static void Main() {
        Console.WriteLine($"{factorialDivision(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())):F2}");
    }

    static double factorialDivision(int num1, int num2) {
        long num1Factorial = 1, num2Factorial = 1; 
        
        for (int i = 1; i <= num1; i++) {
            num1Factorial *= i;
        }

        for (int i = 1; i <= num2; i++) {
            num2Factorial *= i;
        }

        return (double)num1Factorial / num2Factorial;
    }
}
