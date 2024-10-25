using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        int songCount = int.Parse(Console.ReadLine());
        List<Song> songs = new();

        for (int i = 0; i < songCount; i++) {
            string[] data = Console.ReadLine().Split("_").ToArray();

            Song song = new Song(data[0], data[1], data[2]);
            songs.Add(song);
        }

        string typeList = Console.ReadLine();

        if (typeList == "all") {
            foreach (Song s in songs) {
                Console.WriteLine(s.name);
            }
        }
        else {
            foreach (Song s in songs) {
                if (s.type == typeList) {
                    Console.WriteLine(s.name);
                }
            }
        }
    }
}

class Song {
    public Song (string Type, string Name, string Time) {
        type = Type;
        name = Name;
        time = Time;
    }

    public string type {get; set;}
    public string name {get; set;}
    public string time {get; set;}
}