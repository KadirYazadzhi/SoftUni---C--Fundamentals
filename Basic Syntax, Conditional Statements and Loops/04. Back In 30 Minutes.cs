using System;

class Passed {
    static void Main() {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;
        if (minutes > 60) {
            minutes -= 60;
            hours++;
        }

        if (hours > 23) {
            hours = 0;
        }

        Console.Write($"{hours}:");
        if (minutes < 10) {
            Console.Write("0");
        }
         Console.Write($"{minutes}");
    }
}