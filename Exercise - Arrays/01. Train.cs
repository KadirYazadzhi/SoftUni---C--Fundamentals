using System;
using System.Linq;

class Train {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++) {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0; 

        for (int i = 0; i < n; i++) {
            Console.Write(numbers[i] + " ");
            sum += numbers[i];
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
}