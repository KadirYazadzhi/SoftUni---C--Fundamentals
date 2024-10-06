using System;

class MiddleCharacters {
    static void Main() {
        Console.WriteLine(middleCharacters(Console.ReadLine()));
    }

    static string middleCharacters(string words) {
        if (words.Length % 2 == 0) {
            return $"{words[words.Length / 2 - 1]}{words[words.Length / 2]}";
        }
        return $"{words[words.Length / 2]}";
    }
}