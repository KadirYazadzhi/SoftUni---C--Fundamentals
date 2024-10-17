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

            moves++;
            int firstIndex = int.Parse(commands[0]);
            int secondIndex = int.Parse(commands[1]);

            if (characters.Count == 0) {
                Console.WriteLine($"You have won in {moves} turns!");
                return;
            }

            if (isValidIndexes(characters, firstIndex, secondIndex)) {
                if (characters[firstIndex] == characters[secondIndex]) {
                    Console.WriteLine($"Congrats! You have found matching elements - {characters[firstIndex]}!");

                    if (firstIndex < secondIndex) {
                        characters.RemoveAt(secondIndex);
                        characters.RemoveAt(firstIndex);
                    } else {
                        characters.RemoveAt(firstIndex);
                        characters.RemoveAt(secondIndex);
                    }

                    if (characters.Count == 0) {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }
                } 
                else {
                    Console.WriteLine("Try again!");
                }
            } 
            else {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                string newSymbol = "-" + moves + "a";
                characters.InsertRange(characters.Count / 2, new List<string> { newSymbol, newSymbol });
            }
        }

        Console.WriteLine("Sorry you lose :(");
        Console.WriteLine(string.Join(" ", characters));
    }

    static bool isValidIndexes(List<string> characters, int firstIndex, int secondIndex) {
        return firstIndex != secondIndex &&
               firstIndex >= 0 && firstIndex < characters.Count &&
               secondIndex >= 0 && secondIndex < characters.Count;
    }
}
