using System.Text.RegularExpressions;
 
class Demon {
    public string Name { get; }
    public int Health { get; }
    public decimal Damage { get; }

    public Demon(string name, int health, decimal damage) {
        Name = name;
        Health = health;
        Damage = damage;
    }
}

class Program {
    static void Main() {
        string[] demonPatterns = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<Demon> sortedDemons = new List<Demon>();

        foreach (string demonName in demonPatterns) {
            Demon demon = new Demon(demonName, CalculateHealth(demonName), CalculateDamage(demonName));
            sortedDemons.Add(demon);
        }

        sortedDemons = sortedDemons.OrderBy(d => d.Name).ToList();

        foreach (Demon demon in sortedDemons) {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
        }
    }

    static int CalculateHealth(string demonName) {
        int health = 0;

        string wordPattern = @"[^0-9\*\/\+\-\.]"; 
        MatchCollection matches = Regex.Matches(demonName, wordPattern);

        foreach (Match match in matches) {
            health += match.Value[0];
        }

        return health;
    }

    static decimal CalculateDamage(string demonName) {
        decimal damage = 0;

        string numberBasePattern = @"(?:(?:[-+]*)(?:\d+\.\d+|\d+))"; 
        string multiplyPattern = @"[\*\/]";

        MatchCollection matches = Regex.Matches(demonName, numberBasePattern);

        foreach (Match match in matches) {
            decimal number;
            decimal.TryParse(match.Value, out number);
            damage += number;
        }

        matches = Regex.Matches(demonName, multiplyPattern);
        foreach (Match match in matches) {
            switch (match.Value) {
                case "/":
                    damage /= 2;
                    break;
                case "*":
                    damage *= 2;
                    break;
            }
        }

        return damage;
    }
}