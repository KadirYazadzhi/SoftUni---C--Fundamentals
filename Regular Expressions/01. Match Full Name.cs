using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program {
    public static void Main() {
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
        
        string names = Console.ReadLine();
        
        MatchCollection matches = Regex.Matches(names, pattern);
        Console.WriteLine(string.Join(" ", matches.Cast<Match>().Select(match => match.Value)));
    }
}