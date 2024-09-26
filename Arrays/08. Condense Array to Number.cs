using System;
using System.Linq;

class CondenseArrayToNumbers {
    static void Main() {
        int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        while (numbers.Length > 1) {
            int[] condensed = new int[numbers.Length - 1];
            
            for (int i = 0; i < numbers.Length - 1; i++) {
                condensed[i] = numbers[i] + numbers[i + 1];
            }
            numbers = condensed;
        }
        
        Console.WriteLine(numbers[0]); 
    }
}
