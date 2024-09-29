using System;
using System.Linq;

class ToIntegers {
    static void Main() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string result = null; 

        for (int i = 0; i < arr.Length; i++) {
            int num = arr[i];
            bool isValid = true; 

            for (int j = i + 1; j < arr.Length; j++) {
                if (num <= arr[j]) { 
                    isValid = false;
                    break; 
                }
            }

            if (isValid) {
                result += num + " "; 
            }
        }

        Console.WriteLine(result.Trim());
    }
}