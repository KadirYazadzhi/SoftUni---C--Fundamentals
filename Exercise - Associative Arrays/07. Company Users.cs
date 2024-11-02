using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        Dictionary<string, List<string>> companyUsers = new();

        string data = null;
        while ((data = Console.ReadLine()) != "End") {
            string[] arguments = data.Split(" -> ").ToArray();

            if (!companyUsers.ContainsKey(arguments[0])) {
                companyUsers.Add(arguments[0], new List<string>());
            }

            if (!companyUsers[arguments[0]].Contains(arguments[1])) {
                companyUsers[arguments[0]].Add(arguments[1]);
            }
        }

        foreach ((string company, List<string> users) in companyUsers) {
            Console.WriteLine($"{company}");

            foreach (string user in users) {
                Console.WriteLine($"-- {user}");
            }
        }
    }
}