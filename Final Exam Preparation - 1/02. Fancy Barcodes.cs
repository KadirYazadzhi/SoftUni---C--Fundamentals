using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    private static Regex regexToValidateWord = new Regex(@"^(@#+)([A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)");
    private static Regex regexToExtractNumbers = new Regex(@"([0-9]+)");
    
    public static void Main() {
        PrintProductGroup(int.Parse(Console.ReadLine()));
    }

    private static void PrintProductGroup(int n) {
        for (int i = 0; i < n; i++) {
            string line = Console.ReadLine();

            if (!regexToValidateWord.IsMatch(line)) {
                Console.WriteLine("Invalid barcode");
                continue;
            }

            if (regexToExtractNumbers.IsMatch(line)) {
                MatchCollection matches = regexToExtractNumbers.Matches(line);
                Console.WriteLine($"Product group: {string.Join("", matches.Cast<Match>().Select(m => m.Value))}");
                continue;
            }
            
            Console.WriteLine($"Product group: 00");
        }
    }
}

