using System;

class SumNumber {
    static void Main() {
        int count = int.Parse(Console.ReadLine());
        decimal num = 0;
        decimal sum = 0;
        for (int i = 0; i < count; i++) {
            num = decimal.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}