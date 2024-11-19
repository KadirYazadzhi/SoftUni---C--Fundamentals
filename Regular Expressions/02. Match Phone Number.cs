using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program {
    public static void Main() {
        string pattern = @"\+359([ -])[2-9]\1[0-9]{3}\1[0-9]{4}\b";
        
        string phoneNumbers = Console.ReadLine();
        
        MatchCollection matches = Regex.Matches(phoneNumbers, pattern);
        Console.WriteLine(string.Join(", ", matches.Cast<Match>().Select(a => a.Value.Trim()).ToList()));
    }
}
