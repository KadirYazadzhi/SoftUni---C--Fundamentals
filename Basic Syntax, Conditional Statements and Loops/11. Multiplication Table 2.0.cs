using System;

class MultiplicationTable2 {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = num2; i <= 10; i++) {
            sum = num * i;
            Console.WriteLine($"{num} X {i} = {sum}");
        }
        
        if (num2 > 10) {
            sum = num * num2;
            Console.WriteLine($"{num} X {num2} = {sum}");
        }
    }
}
