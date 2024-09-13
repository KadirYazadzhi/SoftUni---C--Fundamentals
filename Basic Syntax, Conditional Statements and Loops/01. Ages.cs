using System;

class Ages {
    static void print(string words) {
        Console.WriteLine(words);
    }

    static void byAge(int age) {
        if (age <= 2) {
            print("baby");
        }
        else if (age <= 13) {
            print("child");
        }
        else if (age <= 19) {
            print("teenager");
        }
        else if (age <= 65) {
            print("adult");
        }
        else {
            print("elder");
        }
    }

    static void Main() {
        int age = int.Parse(Console.ReadLine());
        byAge(age);
    }
}