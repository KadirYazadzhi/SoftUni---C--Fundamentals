using System;

class Program {
    public static string line = null;
    
    static void Main() {
        line = Console.ReadLine();

        string command = null;
        while ((command = Console.ReadLine()) != "Finish") {
            string[] commands = command.Split(" ");

            switch (commands[0]) {
                case "Replace":
                    Replace(commands[1], commands[2]);
                    break;
                case "Cut":
                    Cut(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "Make":
                    Make(commands[1]);
                    break;
                case "Check":
                    Check(commands[1]);
                    break;
                case "Sum":
                    Sum(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
            }
        }
    }

    private static void Replace(string currentChar, string newChar) {
        line = line.Replace(currentChar, newChar);
        Console.WriteLine(line);
    }

    static void Cut(int startIndex, int endIndex) {
        if (!IsValidIndex(startIndex, line) || !IsValidIndex(endIndex, line)) {
            Console.WriteLine("Invalid indices!");
            return;
        }
        
        string result = line.Remove(startIndex, endIndex - startIndex + 1);
        Console.WriteLine(result);
    }

    private static void Make(string type) {
        if (type == "Upper") {
            line = line.ToUpper();
            Console.WriteLine(line);
            return;
        }
        
        line = line.ToLower();
        Console.WriteLine(line);
    }

    private static void Check(string toCheck) {
        if (line.Contains(toCheck)) {
            Console.WriteLine($"Message contains {toCheck}");
            return;
        }
        
        Console.WriteLine($"Message doesn't contain {toCheck}");
    }

    private static void Sum(int startIndex, int endIndex) {
        if (!IsValidIndex(startIndex, line) || !IsValidIndex(endIndex, line)) {
            Console.WriteLine("Invalid indices!");
            return;
        }
        
        int sum = 0;

        for (int i = startIndex; i <= endIndex; i++) {
            sum += line[i];
        }
        
        Console.WriteLine(sum);
    }

    private static bool IsValidIndex(int index, string line) {
        return index >= 0 && index < line.Length;
    }
}
