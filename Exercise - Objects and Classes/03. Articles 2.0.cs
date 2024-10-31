using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        List<Arcticles> arcticles = new();

        for (int i = 0; i < num; i++) {
            string[] data = Console.ReadLine().Split(", ").ToArray();
            Arcticles arc = new Arcticles(data[0], data[1], data[2]);
            arcticles.Add(arc);
        }

        foreach (Arcticles a in arcticles) {
            Console.WriteLine($"{a.title} - {a.content}: {a.author}");
        }
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