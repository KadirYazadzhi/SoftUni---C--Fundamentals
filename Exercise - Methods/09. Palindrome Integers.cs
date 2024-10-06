using System;

class PalindromeIntegers {
    static void Main() {
        string numbers = Console.ReadLine();

        while (numbers != "END") {
            if (isPalindrome(numbers)) {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false"); 
            }

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
