using System;

class PrintingTriangle {
    static void Main() {
        printTriangle(int.Parse(Console.ReadLine())); 
    }

    static void printTriangle(int height) {
        for (int i = 1; i <= height; i++) {
            printNum(1, i);
        }

        for (int i = height - 1; i >= 1; i--) {
            printNum(1, i);
        }
    }

    static void printNum(int start, int end) {
        for (int i = start; i <= end; i++) {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}