using System;

class IntegerOperations {
    static void Main() {
        int integerOne = int.Parse(Console.ReadLine());
        int integerTwo = int.Parse(Console.ReadLine());
        int integerThree = int.Parse(Console.ReadLine());
        int integerFour = int.Parse(Console.ReadLine());

        Console.WriteLine(((integerOne + integerTwo) / integerThree) * integerFour);
    }
}