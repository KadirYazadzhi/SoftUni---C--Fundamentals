using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    public static string key = null;
    
    public static void Main() {
        key = Console.ReadLine();
        ReadData();
    }

    private static void ReadData() {
        string input = null;
        while ((input = Console.ReadLine()) != "Generate") {
            string[] commands = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (commands[0]) {
                case "Contains":
                    Contains(commands[1]);
                    break;
                case "Flip":
                    Flip(commands[1], int.Parse(commands[2]), int.Parse(commands[3]));
                    break;
                case "Slice":
                    Slice(int.Parse(commands[1]), int.Parse(commands[2])); 
                    break;
            }

            if (commands[0] != "Contains") {
                Console.WriteLine(key);
            }
        }
        
        PrintMessage();
    }

    private static void Contains(string element) {
        if (key.Contains(element)) {
            Console.WriteLine($"{key} contains {element}");
            return;
        }
        
        Console.WriteLine("Substring not found!");
    }

    private static void Flip(string type, int startIndex, int endIndex) {
        char[] keyChar = key.ToCharArray();
        
        for (int i = startIndex; i < endIndex; i++) {
            if (type == "Upper") {
                keyChar[i] = char.ToUpper(keyChar[i]);
                continue;
            }
            
            keyChar[i] = char.ToLower(keyChar[i]);
        }
        
        key = new string(keyChar);
    }

    private static void Slice(int startIndex, int endIndex) {
        key = key.Remove(startIndex, endIndex - startIndex);
    }

    private static void PrintMessage() {
        Console.WriteLine($"Your activation key is: {key}");
    }
}

