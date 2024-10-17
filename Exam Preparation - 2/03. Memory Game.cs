using System;
using System.Linq;
using System.Collections.Generic;

class MemoryGame {
    static void Main() {
        List<string> characters = Console.ReadLine().Split().ToList();
        int moves = 0;

        string command = null;
        while ((command = Console.ReadLine()) != "end") {
            string[] commands = command.Split().ToArray();

            if (characters.Count <= 0) {
                Console.WriteLine($"You have won in {moves} turns!");
                return;
            }
            moves++;
            if (isValidIndexes(characters, int.Parse(commands[0]), int.Parse(commands[1]))) {
                if (characters[int.Parse(commands[0])] == characters[int.Parse(commands[1])]) {
                    Console.WriteLine($"Congrats! You have found matching elements - {characters[int.Parse(commands[0])]}!");

                    if (int.Parse(commands[0]) > int.Parse(commands[1])) {
                        characters.RemoveAt(int.Parse(commands[0]));
                        characters.RemoveAt(int.Parse(commands[1]));
                    }
                    else {
                        characters.RemoveAt(int.Parse(commands[1]));
                        characters.RemoveAt(int.Parse(commands[0]) - 1);
                    }
                }
                else {
                    Console.WriteLine("Try again!");
                }
            }
            else {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                characters.Insert(characters.Count / 2, "-" + moves + "a");
                characters.Insert(characters.Count / 2, "-" + moves + "a");
            }
        }

        Console.WriteLine("Sorry you lose :(");
        Console.WriteLine(string.Join(" ", characters));
    }

    static bool isValidIndexes(List<string> characters, int commandOne, int commandTwo) {
        if (commandOne != commandTwo && commandOne >= 0 && commandTwo >= 0 && commandOne < characters.Count && commandTwo < characters.Count) {
            return true;
        }
        return false;
    }
}