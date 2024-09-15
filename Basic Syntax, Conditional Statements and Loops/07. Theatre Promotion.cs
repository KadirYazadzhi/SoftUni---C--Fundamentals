using System;

class Theatre {
    static void Main() {
        string type = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        int price = 0;

        if (type == "Weekday") {
            if (age <= 18) {
                price = 12;
            }
            else if (age <= 64) {
                price = 18;
            }
            else if (age <= 122) {
                price = 12;
            }
        }
        else if (type == "Weekend") {
            if (age <= 18) {
                price = 15;
            }
            else if (age <= 64) {
                price = 20;
            }
            else if (age <= 122) {
                price = 15;
            }
        }
        else if (type == "Holiday") {
            if (age <= 18) {
                price = 5;
            }
            else if (age <= 64) {
                price = 12;
            }
            else if (age <= 122) {
                price = 10;
            }
        }

        if (age < 0 || age > 122) {
            Console.WriteLine("Error!");
        }
        else {
            Console.WriteLine($"{price}$");
        }
    }
}