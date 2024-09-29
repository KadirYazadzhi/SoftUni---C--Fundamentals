using System;
using System.Linq;

class KaminoFactory {
    static void Main() {
        int fieldLength = int.Parse(Console.ReadLine());

        int[] bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] field = new int[fieldLength];

        for (int i = 0; i < bugIndexes.Length; i++) {
            int currentIndex = bugIndexes[i];

            if (currentIndex >= 0 && currentIndex <= field.Length - 1) {
                field[currentIndex] = 1;
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end") {
            string[] arguments = command.Split();

            int bugIndex = int.Parse(arguments[0]);
            string direction = arguments[1];
            int step = int.Parse(arguments[2]);

            if (bugIndex >= 0 && bugIndex < field.Length && field[bugIndex] == 1) {
                field[bugIndex] = 0;

                if (direction == "right") {
                    int landIndex = bugIndex + step;

                    while (landIndex < field.Length && field[landIndex] == 1) {
                        landIndex += step; 
                    }

                    if (landIndex < field.Length) {
                        field[landIndex] = 1; 
                    }
                }
                else if (direction == "left") {
                    int landIndex = bugIndex - step;

                    while (landIndex >= 0 && field[landIndex] == 1) {
                        landIndex -= step;
                    }

                    if (landIndex >= 0) {
                        field[landIndex] = 1; 
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}
