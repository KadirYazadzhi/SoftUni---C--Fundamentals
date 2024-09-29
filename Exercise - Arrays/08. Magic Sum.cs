using System;
using System.Linq;

class MagicSum {
    static void Main() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        string result = null;

        for (int i = 0; i < arr.Length; i++) {
            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[i] + arr[j] == n) {
                    result += arr[i] + " " + arr[j] + "\n";
                }
            }
        }
        Console.WriteLine(result);
    }
}