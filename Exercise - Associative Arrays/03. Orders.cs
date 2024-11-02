using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<Order> orders = new();

        string data = null;
        while ((data = Console.ReadLine()) != "buy") {
            string[] arguments = data.Split().ToArray();

            Order existingOrder = orders.FirstOrDefault(o => o.ProductName == arguments[0]);

            if (existingOrder != null) {
                existingOrder.Price = double.Parse(arguments[1]);
                existingOrder.Quantity += int.Parse(arguments[2]);
                continue;
            } 
            
            orders.Add(new Order(arguments[0], double.Parse(arguments[1]), int.Parse(arguments[2])));
            
        }

        foreach (Order o in orders) {
            Console.WriteLine($"{o.ProductName} -> {o.Price * o.Quantity:F2}");
        }
    }
}

class Order {
    public Order(string productName, double price, int quantity) {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }

    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}
