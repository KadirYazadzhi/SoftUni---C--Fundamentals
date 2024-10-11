using System;
using System.Linq;
using System.Collections.Generic;

class HouseParty {
    static void Main() {
        int membersCount = int.Parse(Console.ReadLine());
        List<string> members = new List<string>();

        for (int i = 0; i < membersCount; i++) {
            string[] commands = Console.ReadLine().Split().ToArray();

            if (commands[2] == "not" && !(findInList(members, commands[0]))) {
                Console.WriteLine($"{commands[0]} is not in the list!");
            }
            else if (commands[2] == "not" && findInList(members, commands[0])) {
                members.Remove(commands[0]);
            }
            else if (commands[2] == "going!" && findInList(members, commands[0])) {
                Console.WriteLine($"{commands[0]} is already in the list!");
            }
            else {
                members.Add(commands[0]);
            }
        }
        printMembersOnTheParty(members);
    }

    static bool findInList(List<string> members, string nameToSearch) {
        for (int i = 0; i < members.Count; i++) {
            if (members[i] == nameToSearch) {
                return true;
            }
        }
        return false;
    }

    static void printMembersOnTheParty(List<string> members) {
        foreach (string name in members) {
            Console.WriteLine(name);
        }
    }
}
