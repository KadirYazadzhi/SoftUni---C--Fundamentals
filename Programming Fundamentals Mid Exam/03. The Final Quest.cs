using System;
using System.Linq;
using System.Collections.Generic;

//"Delete {index}":
//Remove the word after the given index if the word exists (if its index is valid).
//Otherwise, skip the command.

//"Swap {word1} {word2}":
//Find the given words in the collection if they exist and swap their places.
//Otherwise, skip the command.

//"Put {word} {index}":
//Put the word at the index before the given one (index - 1) if the resulting index is valid. 
//If the word's index is out of range, skip the command.
//Exception: If the given index is equal to the length of the list, you should put the word at the end of the list.

//"Sort":
//You should sort the words in descending order.

//"Replace {word1} {word2}":
//Find the second word in the collection (if it exists) and replace it with the first given word.
//Otherwise, skip the command.


internal class Program {
    static void Main() {
        List<string> list = Console.ReadLine().Split().ToList();

        string commands = "";

        while ((commands = Console.ReadLine()) != "Stop") {
            string[] arguments = commands.Split();

            switch (arguments[0]) {
                case "Delete":
                    if (isValidIndex(list, int.Parse(arguments[1]) + 1)) {
                        list.RemoveAt(int.Parse(arguments[1]) + 1);
                    }
                    break;

                case "Swap":
                    if (list.Contains(arguments[1]) && list.Contains(arguments[2])) {
                        string swap = list[list.IndexOf(arguments[1])];
                        list[list.IndexOf(arguments[1])] = list[list.IndexOf(arguments[2])];
                        list[list.IndexOf(arguments[2])] = swap;
                    }
                    break;

                case "Put":
                    if (isValidIndex(list, int.Parse(arguments[2]) - 1)) {
                        list.Insert(int.Parse(arguments[2]) - 1, arguments[1]);
                    }
                    else if (int.Parse(arguments[2]) - 1 == list.Count) {
                        list.Add(arguments[1]);
                    }
                    break;

                case "Sort":
                    list = list.OrderByDescending(x => x).ToList();
                    break;

                case "Replace":
                    if (list.Contains(arguments[2])) {
                        list[list.IndexOf(arguments[2])] = arguments[1];
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }


    static bool isValidIndex(List<string> list, int index) {
        return index >= 0 && index < list.Count;
    }

    static int findIndex(List<string> list, string element) {
        int i = 0;
        for (; i < list.Count; i++) {
            if (list[i] == element) {
                break;
            }
        }
        return i;
    }
}