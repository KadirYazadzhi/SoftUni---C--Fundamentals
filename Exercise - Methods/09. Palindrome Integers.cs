using System;

class PalindromeIntegers {
    static void Main() {
        string numbers = Console.ReadLine();

        while (numbers != "END") {
            Console.WriteLine(isPalindrome(numbers));

            numbers = Console.ReadLine();
        }
    }

    static bool isPalindrome(string numbers) {
        string reverse = "";
        for (int i = numbers.Length - 1; i >= 0; i--) {
            reverse += numbers[i];
        }

        return reverse == numbers;
    }
}
