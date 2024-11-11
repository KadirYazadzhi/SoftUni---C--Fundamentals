using System;
using System.Collections.Generic;
using System.Linq;

class Program {

    static void Main() {
        List<string> list = Console.ReadLine().Split().ToList();
        
        Console.WriteLine(SumString(list[0], list[1]));
    }

    static int SumString(string wordOne, string wordTwo) {
        int sum = 0;
        
        for (int i = 0; i < Math.Min(wordOne.Length, wordTwo.Length); i++) {
            sum += wordOne[i] * wordTwo[i];
        }
        
        string longerWord = wordOne.Length > wordTwo.Length ? wordOne : wordTwo;
        for (int i = Math.Min(wordOne.Length, wordTwo.Length); i < longerWord.Length; i++) {
            sum += longerWord[i];
        }

        return sum;
    }
}

