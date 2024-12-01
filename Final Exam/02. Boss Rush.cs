using System;
using System.Text.RegularExpressions;

class Program {
    public static string pattern = @"^\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#$";
    
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) {
            IsValid(Console.ReadLine());
        }
    }

    private static void IsValid(string input) {
        Match match = Regex.Match(input, pattern);

        if (match.Success) {
            string bossName = match.Groups[1].Value; 
            string title = match.Groups[2].Value;   

            Console.WriteLine($"{bossName}, The {title}");
            Console.WriteLine($">> Strength: {bossName.Length}");
            Console.WriteLine($">> Armor: {title.Length}");
            return;
        }
        
        Console.WriteLine("Access denied!");
    }
}
