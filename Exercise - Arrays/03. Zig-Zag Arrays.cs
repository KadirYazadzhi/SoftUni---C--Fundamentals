using System;
using System.Linq;

class ZigZag {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        string oddCombination = null;
        string evenCombination = null;

        for (int i = 0; i < n; i++) {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (i % 2 != 0) {
                oddCombination += arr[1] + " ";
                evenCombination += arr[0] + " ";
            }
            else {
                oddCombination += arr[0] + " ";
                evenCombination += arr[1] + " ";
            }
        }
        Console.WriteLine(oddCombination);
        Console.WriteLine(evenCombination);
    }
}