using System;
using System.Linq;
using System.Collections.Generic;

class BombNumbers {
    static void Main() {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] commandNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Count; i++) {
            if (numbers[i] == commandNumbers[0]) { 
                for (int j = 1; j <= commandNumbers[1]; j++) {
                    if (i + 1 < numbers.Count) {
                        numbers.RemoveAt(i + 1);  
                    }
                    if (i - 1 >= 0) {
                        numbers.RemoveAt(i - 1);  
                        i--;  
                    }
                }
                numbers.RemoveAt(i);  
                i--;  
            }
        }

        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }

        Console.WriteLine(sum);
    }
}

