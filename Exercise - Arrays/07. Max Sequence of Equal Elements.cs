using System;
using System.Linq;

class EqualElements {
    static void Main() {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int resultNumber = 0;
        int resultCount = 0;

        int count = 0; 
        for (int i = 0; i < arr.Length; i++) {
            int num = arr[i];
            for (int j = i; j < arr.Length; j++) {
                if (arr[j] == num) {
                    count++;
                }
                else {
                    break;
                }
            }
            if (count > resultCount) {
                resultCount = count;
                resultNumber = num;
            }
            count = 0;
        }

        for (int i = 0; i < resultCount; i++) {
            Console.Write(resultNumber + " ");
        }
    }
}