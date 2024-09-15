using System;

class VendingMachine {
    static void Main() {
        string data = Console.ReadLine();
        double sum = 0;

        while (data != "Start") {
            double coin;
            if (double.TryParse(data, out coin)) {
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2) {
                    sum += coin;
                } else {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
            data = Console.ReadLine();
        }

        data = Console.ReadLine();
        while (data != "End") {
            if (data == "Nuts" && sum >= 2.0) {
                Console.WriteLine("Purchased nuts");
                sum -= 2.0;
            } 
            else if (data == "Water" && sum >= 0.7) {
                Console.WriteLine("Purchased water");
                sum -= 0.7;
            } 
            else if (data == "Crisps" && sum >= 1.5) {
                Console.WriteLine("Purchased crisps");
                sum -= 1.5;
            } 
            else if (data == "Soda" && sum >= 0.8) {
                Console.WriteLine("Purchased soda");
                sum -= 0.8;
            } 
            else if (data == "Coke" && sum >= 1.0) {
                Console.WriteLine("Purchased coke");
                sum -= 1.0;
            } 
            else if (data == "Nuts" || data == "Water" || data == "Crisps" || data == "Soda" || data == "Coke") {
                Console.WriteLine("Sorry, not enough money");
            } 
            else {
                Console.WriteLine("Invalid product");
            }

            data = Console.ReadLine();
        }

        Console.WriteLine($"Change: {sum:F2}");
    }
}
