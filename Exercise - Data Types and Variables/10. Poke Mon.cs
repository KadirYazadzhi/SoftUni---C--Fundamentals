using System;

class PokeMon {
    static void Main() {
        int power = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        double halfPower = power / 2.0;
        int count = 0;

        while (power >= distance) {
            power -= distance;
            count++;

            if (power == halfPower && exhaustionFactor != 0) {
                power /= exhaustionFactor;
            }
        }

        Console.WriteLine(power);
        Console.WriteLine(count);
    } 
}