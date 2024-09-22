using System;

class SumOfChars {
    static void Main() {
        int alphabetStartNumber = int.Parse(Console.ReadLine());
        int alphabetEndNumber = int.Parse(Console.ReadLine());
        
        for (int i = alphabetStartNumber; i <= alphabetEndNumber; i++) {
            char alphabet = (char) i;
            Console.Write(alphabet + " ");
        }
    }
}