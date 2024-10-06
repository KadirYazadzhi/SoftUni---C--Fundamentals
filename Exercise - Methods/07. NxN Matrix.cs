using System;

class NxNMatrix {
    static void Main() {
        printMatrix(int.Parse(Console.ReadLine()));
    }

    static void printMatrix(int num) {
        for (int i = 0; i < num; i++) {
            for (int j = 0; j < num; j++) {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}