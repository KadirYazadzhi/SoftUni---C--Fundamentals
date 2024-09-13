using System;

class Ages {
    static double result(int groupNum, string type, string day) {
        double result = 0;
        if (type == "Students") {
            if (day == "Friday") {
                result = groupNum * 8.45;
            }
            else if (day == "Saturday") {
                result = groupNum * 9.80;
            }
            else if (day == "Sunday") {
                result = groupNum * 10.46;
            }

            if (groupNum >= 30) {
                result *= 0.85;
            }
        }
        else if (type == "Business") {
            if (day == "Friday") {
                result = groupNum * 10.90;
            }
            else if (day == "Saturday") {
                result = groupNum * 15.60;
            }
            else if (day == "Sunday") {
                result = groupNum * 16;
            }

            if (groupNum >= 100) {
                result -= (10 * (result / groupNum));
            }
        }
        else {
            if (day == "Friday") {
                result = groupNum * 15;
            }
            else if (day == "Saturday") {
                result = groupNum * 20;
            }
            else if (day == "Sunday") {
                result = groupNum * 22.50;
            }

            if (groupNum >= 10 && groupNum <= 20) {
                result *= 0.95;
            }
        }

        return result;
    }

    static void Main() {
        int groupNum = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();

        Console.WriteLine($"Total price: {result(groupNum, type, day):F2}");
    }
}