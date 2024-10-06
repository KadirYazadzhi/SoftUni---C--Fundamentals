using System;

class VowelsCount {
    static void Main() {
        Console.WriteLine(vowelsCount());
    }

    static int vowelsCount() {
        string words = Console.ReadLine().ToLower();
        int count = 0;

        foreach (char c in words) {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
                count++;
            }
        }
        return count;
    }
}
