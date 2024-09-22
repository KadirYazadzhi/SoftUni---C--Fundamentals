using System;

class SumDigits {
    static void Main() {
        string number = Console.ReadLine();
        
        int sum = 0;
        for (int i = 0; i < number.Length; i++) {
            int digit = number[i] - '0';
            
            sum += digit;
        }
        Console.WriteLine(sum);
    }
}