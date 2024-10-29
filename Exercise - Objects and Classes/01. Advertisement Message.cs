using System;
using System.Linq;
using System.Collections.Generic;

internal class Program {
    static void Main() {
        List<string> phrases = new() {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};
        List<string> events = new() {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
        List<string> authors = new() {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        List<string> cities = new() {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

        Random random = new Random();

        Console.WriteLine($"{phrases[random.Next(phrases.Count)]} {events[random.Next(events.Count)]} {authors[random.Next(authors.Count)]} - {cities[random.Next(cities.Count)]}");
    }
}