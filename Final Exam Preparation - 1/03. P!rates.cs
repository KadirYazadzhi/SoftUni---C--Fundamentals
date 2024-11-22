using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    private static List<City> cities = new List<City>();
    
    public static void Main() {
        GetCities();
        PiratesStart();
        PiratesEnd();
    }

    private static void GetCities() {
        string line = null;
        while ((line = Console.ReadLine()) != "Sail") {
            string[] data = line.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int index = isContains(data[0], cities);
            if (index != -1) {
                cities[index].People += int.Parse(data[1]);
                cities[index].Gold += int.Parse(data[2]);
                continue;
            }
           
            City city = new City(data[0], int.Parse(data[1]), int.Parse(data[2]));
           
            cities.Add(city);
        }
    }

    private static void PiratesStart() {
        string line = null;
        while ((line = Console.ReadLine()) != "End") {
            string[] commands = line.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (commands[0]) {
                case "Plunder":
                    PlunderCity(commands[1], int.Parse(commands[2]), int.Parse(commands[3]));
                    break;
                case "Prosper":
                    ProsperCity(commands[1], int.Parse(commands[2]));
                    break;
            }
        }
    }

    private static void ProsperCity(string city, int gold) {
        if (gold < 0) {
            Console.WriteLine("Gold added cannot be a negative number!");
            return;
        }
        
        int index = isContains(city, cities);
        cities[index].Gold += gold;
        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[index].Gold} gold.");
    }

    private static void PlunderCity(string city, int people, int gold) {
        int index = isContains(city, cities);
        
        cities[index].Gold -= gold;
        cities[index].People -= people;
        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
        
        if (cities[index].Gold <= 0 || cities[index].People <= 0) {
            Console.WriteLine($"{city} has been wiped off the map!");
            cities.RemoveAt(index);

        }
    }

    private static void PiratesEnd() {
        if (cities.Count == 0) {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            return;
        }

        Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
        PrintCities();
    }

    private static void PrintCities() {
        foreach ((string name, int people, int gold) in cities) {
            Console.WriteLine($"{name} -> Population: {people} citizens, Gold: {gold} kg");
        }
    }

    private static int isContains(string city, List<City> cities) {
        for (int i = 0; i < cities.Count; i++) {
            if (cities[i].Name == city) {
                return i;
            }
        }

        return -1;
    }
}

public class City {
    public City(string name, int people, int gold) {
        Name = name;
        People = people;
        Gold = gold;
    }
    
    public void Deconstruct(out string name, out int people, out int gold) {
        name = Name;
        gold = Gold;
        people = People;
    }
    
    public string Name { get; set; }
    public int People { get; set; }
    public int Gold { get; set; }
}
