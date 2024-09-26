using System;
using System.Linq;

class EqualArray {
    static void Main() {
        int[] numbersArrayOne = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] numbersArrayTwo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sum = 0;
        bool isValid = true;
        int index = 0;

        for (int i = 0; i < numbersArrayOne.Length; i++) {
            if (numbersArrayOne[i] != numbersArrayTwo[i]) {
                isValid = false;
                index = i;
                break;
            }
            sum += numbersArrayOne[i];
        }

        if (isValid) {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
        else {
            Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
        }
    }
}