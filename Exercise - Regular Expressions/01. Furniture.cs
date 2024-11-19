using System.Text.RegularExpressions;

public class Furniture {
    public Furniture(string name, decimal price, int quantity) {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    public string Name { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Total {
        get { return Price * Quantity; }
    }
}

public class Program {
    static void Main() {
    
        List<Furniture> furnitures = new List<Furniture>();

        string pattern = @">>([A-z]+)<<(\d+\.\d+|\d+)!(\d+)";

        string command;
        while ((command = Console.ReadLine()) != "Purchase") {
            foreach (Match m in Regex.Matches(command, pattern)) {
                Furniture furniture = new Furniture(m.Groups[1].Value, decimal.Parse(m.Groups[2].Value), int.Parse(m.Groups[3].Value));

                furnitures.Add(furniture);
            }
        }

        Console.WriteLine("Bought furniture:");
        decimal totalSpend = 0m;
        foreach (Furniture furniture in furnitures) {
            Console.WriteLine(furniture.Name);
            totalSpend += furniture.Total;
        }
        
        Console.WriteLine($"Total money spend: {totalSpend:F2}");
    }
}
