using System;

class SumOfChars {
    static void Main() {
        int alphabetCount = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for (int i = 0; i < alphabetCount; i++) {
            char alphabet = char.Parse(Console.ReadLine());

            sum += (int)alphabet;
        }
        Console.WriteLine("The sum equals: " + sum);
    }
}