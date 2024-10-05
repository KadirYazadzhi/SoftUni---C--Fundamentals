using System;

class Calculator {
    static void Main() {
        Console.WriteLine(calculatorLogic(Console.ReadLine()));
    }

    static int calculatorLogic(string type) {
        switch(type) {
            case "add":
                return add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            case "multiply":
                return multiply(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            case "subtract":
                return subtract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            case "divide":
                return divide(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            default:
                throw new ArgumentException("Invalid operation type");
        }
    }

    static int add(int num1, int num2) {
        return num1 + num2;
    }

    static int multiply(int num1, int num2) {
        return num1 * num2;
    }

    static int subtract(int num1, int num2) {
        return num1 - num2;
    }

    static int divide(int num1, int num2) {
        if (num2 == 0) {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}