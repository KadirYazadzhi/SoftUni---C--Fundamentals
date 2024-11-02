using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, double> metalsQuantity = new();

        while (true) {
            string metal = Console.ReadLine();

            if (metal == "stop") break;

            double quantity = double.Parse(Console.ReadLine());

            if (!metalsQuantity.ContainsKey(metal)) {
                metalsQuantity.Add(metal, quantity);
                continue;
            }

            metalsQuantity[metal] += quantity;
        }

        foreach ((string metal, double quantity) in metalsQuantity) {
            Console.WriteLine($"{metal} -> {quantity}");
        }
    }
}