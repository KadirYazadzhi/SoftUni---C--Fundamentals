using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

public class Program {
    public static void Main() {
        Dictionary<string, int> participantMap = new Dictionary<string, int>();
        
        string[] participantsArray = Console.ReadLine().Split(", ");
        foreach (string participant in participantsArray) {
            participantMap[participant] = 0;
        }
        
        string digitsPattern = @"\d";
        string lettersPattern = @"[A-Za-z]";

        string input = null;
        while ((input = Console.ReadLine()) != "end of race") {
            StringBuilder foundName = new StringBuilder();

            foreach (Match match in Regex.Matches(input, lettersPattern)) {
                foundName.Append(match.Value);
            }

            string name = foundName.ToString();
            
            if (participantMap.ContainsKey(name)) {
                int distance = 0;

                foreach (Match match in Regex.Matches(input, digitsPattern)) {
                    distance += int.Parse(match.Value);
                }
                
                participantMap[name] += distance;
            }
        }

        var topParticipants = participantMap.OrderByDescending(p => p.Value).Take(3).Select(p => p.Key).ToList();

        Console.WriteLine($"1st place: {topParticipants[0]}");
        Console.WriteLine($"2nd place: {topParticipants[1]}");
        Console.WriteLine($"3rd place: {topParticipants[2]}");
    }
}
