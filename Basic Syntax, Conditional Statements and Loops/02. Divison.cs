using System;

class Division {
    static int isDivisible(int num) {
        int result = 0;
        if (num % 2 == 0) {
            result = 2;
        }
        if (num % 3 == 0) {
            result = 3;
        }
        if (num % 6 == 0) {
            result = 6;
        }
        if (num % 7 == 0) {
            result = 7;
        }
        if (num % 10 == 0) {
            result = 10;
        }
        return result;
    }


    static void Main() {
        int num = int.Parse(Console.ReadLine());
        if (Convert.ToBoolean(isDivisible(num))) {
            Console.WriteLine("The number is divisible by " + isDivisible(num));
        }
        else {
            Console.WriteLine("Not divisible");
        }
    }
}