using System;
using System.Numerics;

class BigFactorial {
    static void Main() {
        Console.WriteLine(factorial(int.Parse(Console.ReadLine())));
    }

    public static BigInteger factorial(int num) {
        BigInteger sum = new BigInteger(1);
        for (int i = 1; i <= num; i++) {
            sum *= i;
        }
        return sum;
    }
}