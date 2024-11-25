using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    public static string line = null;
    public static Regex emojiRegex = new Regex(@"(\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1");
    public static Regex numbersRegex = new Regex(@"\d");
    
    public static void Main() {
        line = Console.ReadLine();
        Action();
    }

    private static void Action() {
        MatchCollection emoji = emojiRegex.Matches(line);
        MatchCollection numbers = numbersRegex.Matches(line);
        
        long sum = numbers.Select(n => int.Parse(n.Value.ToString())).Aggregate(1, (product, number) => product * number);
        List<string> coolsEmoji  = isCool(sum, emoji);
        
        printFinalMessage(sum, coolsEmoji, emoji);
    }

    private static List<string> isCool(long sum, MatchCollection emoji) {
        List<string> coolsEmoji = new List<string>();
        
        foreach (Match item in emoji) {
            long itemSum = item.Groups["emoji"].Value.Select(n => (int)n).Sum();

            if (itemSum >= sum) {
                coolsEmoji.Add(item.Value);
            }
        }

        return coolsEmoji;
    }

    private static void printFinalMessage(long sum, List<string> coolsEmoji, MatchCollection emoji) {
        Console.WriteLine($"Cool threshold: {sum}");
        Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");

        foreach (string item in coolsEmoji) {
            Console.WriteLine(item);
        }
    }
}


