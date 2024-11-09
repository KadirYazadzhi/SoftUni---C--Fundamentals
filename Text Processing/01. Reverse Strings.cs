using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        string word = null;
        while ((word = Console.ReadLine()) != "end") {
            Console.WriteLine($"{word} = {Reverse(word)}");
        }
    }

    public static string Reverse(string word) {
        string reversed = null;

        for (int i = word.Length - 1; i >= 0; i--) {
            reversed += word[i];
        }
        return reversed;
    }
}



