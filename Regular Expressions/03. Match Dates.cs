using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program {
    public static void Main() {
        string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        
        var datesStrings = Console.ReadLine();
        
        var dates = Regex.Matches(datesStrings, pattern);
        foreach (Match date in dates) {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}