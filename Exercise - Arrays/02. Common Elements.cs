using System;
using System.Linq;

class CommonElements {
    static void Main() {
        string[] arr1 = Console.ReadLine().Split().ToArray();
        string[] arr2 = Console.ReadLine().Split().ToArray();
        string result = null;

        for (int i = 0; i < arr2.Length; i++) {
            string word = arr2[i];

            for (int j = 0; j < arr1.Length; j++) {
                if (word == arr1[j]) {
                    result += arr1[j] + " ";
                }
            }
        }
        Console.WriteLine(result);
    }
}