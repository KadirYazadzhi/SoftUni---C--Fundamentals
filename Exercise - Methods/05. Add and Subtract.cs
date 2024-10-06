using System;

class AddAndSubstract {
    static void Main() {
        Console.WriteLine(addAndSubstract());
    }

    static int addAndSubstract() {
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++) {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers[0] + numbers[1] - numbers[2];
    }

}
