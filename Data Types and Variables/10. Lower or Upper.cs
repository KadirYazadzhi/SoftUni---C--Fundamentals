using System;

class LowerOrUpper {
    static void Main() {
        char ch = char.Parse(Console.ReadLine());
        if ((int)ch >= 65 && (int)ch <= 90) {
            Console.WriteLine("upper-case");
        }
        else {
            Console.WriteLine("lower-case");
        }
    }
}