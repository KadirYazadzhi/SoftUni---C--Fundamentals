using System;

class CharsToString {
    static void Main() {
        string ch = null;
        string word = null;

        for (int i = 0; i < 3; i++) {
            ch = Console.ReadLine();
            word += ch;
        }
        Console.WriteLine(word);
    }
}