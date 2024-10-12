using System;
using System.Linq;
using System.Collections.Generic;


class ListsOperations {
    static void Main() {
        List<string> lessons = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();

        string command = null;
        while ((command = Console.ReadLine()) != "course start") {
            string[] commands = command.Split(':').ToArray();

            switch (commands[0]) {
                case "Add":
                    if (!lessons.Contains(commands[1])) {
                        lessons.Add(commands[1]);
                    }
                break;

                case "Insert":
                    if (!lessons.Contains(commands[1]) && int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < lessons.Count) {
                        lessons.Insert(int.Parse(commands[2]), commands[1]);
                    }
                break;

                case "Remove":
                    if (lessons.Contains(commands[1])) {
                        lessons.Remove(commands[1]);
                    }
                    if (findIndex(lessons, commands[1] + "-Exercise") != -1) {
                        lessons.RemoveAt(findIndex(lessons, commands[1] + "-Exercise"));
                    }
                break;

                case "Swap":
                    lessons = Swap(lessons, commands[1], commands[2]);
                break;

                case "Exercise":
                    int lessonIndex = findIndex(lessons, commands[1]);
                    if (lessonIndex != -1 && findIndex(lessons, commands[1] + "-Exercise") == -1) {
                        lessons.Insert(lessonIndex + 1, commands[1] + "-Exercise");
                    }
                    else if (lessonIndex == -1) {
                        lessons.Add(commands[1]);
                        lessons.Add(commands[1] + "-Exercise");
                    }
                break;

            }
        }
        printLessons(lessons);
    }

    static List<string> Swap(List<string> lessons, string lessonFirst, string lessonSecond) {
        if (lessons.Contains(lessonFirst) && lessons.Contains(lessonSecond)) {
            for (int i = 0; i < lessons.Count; i++) {
                if (lessons[i] == lessonFirst) {
                    lessonFirst = i.ToString();
                }
                else if (lessons[i] == lessonSecond) {
                    lessonSecond = i.ToString();
                }
            }

            string swap = lessons[int.Parse(lessonFirst)];
            lessons[int.Parse(lessonFirst)] = lessons[int.Parse(lessonSecond)];
            lessons[int.Parse(lessonSecond)] = swap;

            if (lessons.Contains(lessons[int.Parse(lessonFirst)] + "-Exercise")) {
                lessons.Remove(lessons[int.Parse(lessonFirst)] + "-Exercise");
                lessons.Insert(int.Parse(lessonFirst) + 1, lessons[int.Parse(lessonFirst)] + "-Exercise");
            }
            if (lessons.Contains(lessons[int.Parse(lessonSecond)] + "-Exercise")) {
                lessons.Remove(lessons[int.Parse(lessonSecond)] + "-Exercise");
                lessons.Insert(int.Parse(lessonSecond) + 1, lessons[int.Parse(lessonSecond)] + "-Exercise");
            }
        }
        return lessons;
    }

    static void printLessons (List<string> lessons) {
        for (int i = 0; i < lessons.Count; i++) {
            Console.WriteLine($"{i + 1}.{lessons[i]}");
        }
    }

    static int findIndex(List<string> lessons, string lesson) {
        for (int i = 0; i < lessons.Count; i++) {
            if (lessons[i] == lesson) {
                return i;
            }
        }
        return -1;
    }

}
