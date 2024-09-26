using System;

class DayOfWeek {
    static void Main() {
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        int num = int.Parse(Console.ReadLine());

        if (num < 1 || num > 7) {
            Console.WriteLine("Invalid day!");
        }
        else {
            Console.WriteLine(days[num - 1]);
        }
    }
}