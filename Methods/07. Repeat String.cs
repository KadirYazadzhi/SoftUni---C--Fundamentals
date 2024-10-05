using System;

class RepeatString {
    static void Main() {
        printNTimes(Console.ReadLine(), int.Parse(Console.ReadLine()));
    }

    static void printNTimes(string word, int num) {
        for (int i = 0; i < num; i++) {
            Console.Write(word);
        }

        Console.WriteLine();
    }
}