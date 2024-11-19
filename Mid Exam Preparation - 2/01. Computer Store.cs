using System;
using System.Linq;
using System.Collections.Generic;

class ComputerStore {
    static void Main() {
        store();
    }

    static void store() {
        double sum = 0;
        double withoutTaxes = 0;
        double taxes = 0;

        string command = Console.ReadLine();
        while (command != "special" && command != "regular") {
            if (double.Parse(command) >= 0) {
                sum += double.Parse(command);
            }
            else {
                Console.WriteLine("Invalid price!");
            }

            command = Console.ReadLine();
        }

        withoutTaxes = sum;
        sum = withoutTaxes * 1.2;
        taxes = withoutTaxes * 0.2;
        if (command == "special") {
            sum *= 0.9;
        }
        print(sum, withoutTaxes, taxes);
    }

    static void print(double sum, double withoutTaxes, double taxes) {
        if (sum == 0) {
            Console.WriteLine("Invalid order!");
        }
        else {
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {withoutTaxes:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {sum:F2}$");
        }
    }
}