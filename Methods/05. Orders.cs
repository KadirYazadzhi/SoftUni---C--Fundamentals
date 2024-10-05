using System;

class Orders {
    static void Main() {
        Console.WriteLine($"{calculatePrice(Console.ReadLine(), double.Parse(Console.ReadLine())):F2}");
    }

    static double calculatePrice(string product, double num) {
        switch (product) {
            case "coffee":
                return 1.50 * num;
            case "water":
                return 1.00 * num;
            case "coke":
                return 1.40 * num;
            case "snacks":
                return 2.00 * num;
        }

        return 0;
    }
}