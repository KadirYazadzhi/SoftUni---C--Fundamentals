using System;
using System.Text.RegularExpressions;

class PasswordValidator {
    static void Main() {
        string password = Console.ReadLine();
        bool isValid = true;

        if (!countCharacters(password)) {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }
        if (!validateForDigitsAndLetters(password)) {
            Console.WriteLine("Password must consist only of letters and digits");
            isValid = false;
        }
        if (!countDigits(password)) {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        if (isValid) {
            Console.WriteLine("Password is valid");
        }
    }

    static bool countCharacters(string password) {
        return password.Length >= 6 && password.Length <= 10;
    }

    static bool validateForDigitsAndLetters(string password) {
        foreach (char c in password) {
            if (!char.IsLetterOrDigit(c)) {
                return false;
            }
        }
        return true;
    }

    static bool countDigits(string password) {
        int digitCount = 0;
        foreach (char c in password) {
            if (char.IsDigit(c)) {
                digitCount++;
            }
        }
        return digitCount >= 2;
    }
}
