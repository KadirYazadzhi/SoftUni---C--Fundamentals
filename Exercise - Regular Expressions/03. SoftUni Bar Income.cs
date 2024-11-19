using System.Text.RegularExpressions;

class Order {
    public Order(string customer, string product, uint count, decimal price) {
        Customer = customer;    
        Product = product;
        Count = count;
        Price = price;
    }
    public string Customer { get; set; }

    public string Product { get; set; }
    
    public uint Count { get; set; }
    
    public decimal Price { get; set; }

    public decimal TotalPrice {
        get {
            return Count * Price;
        }
    }
}

public class Program {
    static void Main() {
        decimal totalIncome = 0;

        string command;
        while ((command = Console.ReadLine()) != "end of shift") {
            string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";
            
            if (Regex.IsMatch(command, pattern) == false) {
                continue;
            }
            
            Match match = Regex.Match(command, pattern);

            Order order = new Order(match.Groups[1].Value, match.Groups[2].Value, uint.Parse(match.Groups[3].Value), decimal.Parse(match.Groups[4].Value));

            totalIncome += order.TotalPrice;
            Console.WriteLine($"{order.Customer}: {order.Product} - {order.TotalPrice:F2}");
        }
        
        Console.WriteLine($"Total income: {totalIncome:F2}");
    }
}