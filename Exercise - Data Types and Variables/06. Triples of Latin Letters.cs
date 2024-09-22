using System;

class LatinLettersPrint {
    static void Main() {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++) {
            char firstChar = (char)('a' + i);
            for (int j = 0; j < num; j++) {
                char secondChar = (char)('a' + j);
                for (int k = 0; k < num; k++) {
                    char thirdChar = (char)('a' + k);
                    
                    Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                }
            }
        }
    }
}