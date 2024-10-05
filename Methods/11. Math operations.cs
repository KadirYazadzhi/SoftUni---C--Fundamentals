using System;

class MathOperations {
    static void Main() {
        Console.WriteLine(calculator(int.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }

    static object calculator(int num1, char operatorType, int num2) {
        switch (operatorType) {
            case '+':
                return num1 + num2;

            case '-':
                return num1 - num2;

            case '*':
                return num1 * num2;
            
            case '/':
                return num1 / num2;

            default:
                throw new ArgumentException("Invalid type");
        }
    }
}
