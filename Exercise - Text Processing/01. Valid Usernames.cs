using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program {

    static void Main() {
        List<string> list = Console.ReadLine().Split(", ").ToList();

        foreach (string word in list) {
            if (isValid(word)) {
                Console.WriteLine(word);
            }
        }
    }

    static bool isValid(string word) {
        if (!Regex.IsMatch(word, @"^[a-zA-Z0-9_-]+$") || word.Length < 3 || word.Length > 16) {
            return false;
        }
        
        return true;
    }
}
