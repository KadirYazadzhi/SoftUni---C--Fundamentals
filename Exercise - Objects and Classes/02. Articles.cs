using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> arcticles = Console.ReadLine().Split(", ").ToList();
        int num = int.Parse(Console.ReadLine());

        Arcticles arc = new Arcticles(arcticles[0], arcticles[1], arcticles[2]);

        for (int i = 0; i < num; i++) {
            string[] commands = Console.ReadLine().Split(": ").ToArray();

            switch (commands[0]) {
                case "Edit":
                    arc.content = commands[1];
                break;

                case "ChangeAuthor":
                    arc.author = commands[1];
                break;

                case "Rename":
                    arc.title = commands[1];
                break;
            }
        }

        Console.WriteLine($"{arc.title} - {arc.content}: {arc.author}");
    }
}

class Arcticles {
    public Arcticles (string Title, string Content, string Author) {
        title = Title;
        content = Content;
        author = Author;
    }

    public string title {get; set;}
    public string content {get; set;}
    public string author {get; set;}
}