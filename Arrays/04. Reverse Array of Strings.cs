using System;
using System.Linq;

class ReverseString {
    static void Main() {
        string[] arr = Console.ReadLine().Split().Select().ToArray();

        for (int i = 0; i < arr.Length; i++) {
            Console.Write($"{arr[arr.Length - i - 1]} ");
        }
    }
}