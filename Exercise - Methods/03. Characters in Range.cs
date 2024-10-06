using System;

class CharactersInRange {
    static void Main() {
        printCharacters(((int)(char.Parse(Console.ReadLine()))), ((int)(char.Parse(Console.ReadLine()))));
    }

    static void printCharacters(int start, int end) {
        if (start > end) {
            int other = start;
            start = end;
            end = other;
        }

        for (int i = start + 1; i < end; i++) {
            Console.Write((char)i + " ");
        }
    }
}
