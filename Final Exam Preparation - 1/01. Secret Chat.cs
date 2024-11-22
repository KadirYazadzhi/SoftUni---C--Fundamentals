using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    private static string line = null;
    
    public static void Main() {
        line = Console.ReadLine();

        ReadCommands();
        Console.WriteLine($"You have a new text message: {line}");
    }

    private static string ReadCommands() {
        string command = null;
        while ((command = Console.ReadLine()) != "Reveal") {
            List<string> commands = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToList();

            switch (commands[0]) {
                case "InsertSpace":
                    InsertSpaces(int.Parse(commands[1]));
                    break;
                case "Reverse":
                    Reverse(commands[1]);
                    break;
                case "ChangeAll":
                    ChangeAll(commands[1], commands[2]);
                    break;
            }

            if (commands[0] == "Reverse") {
                continue;
            }
            
            Console.WriteLine(line);
        }
        
        return line;
    }

    private static void InsertSpaces(int index) {
        List<char> chars = line.ToList();
        
        chars.Insert(index, ' ');
        
        line = new string(chars.ToArray());
    }

    private static void Reverse(string toReversed) {
        if (line.IndexOf(toReversed) != -1) {
            line = line.Replace(line.Substring(line.IndexOf(toReversed), toReversed.Length), new string(toReversed.Reverse().ToArray()));
            Console.WriteLine(line);
        }
        else {
            Console.WriteLine("error");
        }
    }
    
    private static void ChangeAll(string elementToChange, string newElement) {
        line = line.Replace(elementToChange, newElement);
    }
}
