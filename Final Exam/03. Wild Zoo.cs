using System;
using System.Text.RegularExpressions;

class Program {
    public static List<Animal> animals = new List<Animal>();
    
    static void Main() {
        string line = null;

        while ((line = Console.ReadLine()) != "EndDay") {
            string[] tokens = line.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] data = tokens[1].Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (tokens[0]) {
                case "Add":
                    AddAnimal(data[0], int.Parse(data[1]), data[2]);
                    break;
                case "Feed":
                    FeedAnimal(data[0], int.Parse(data[1]));
                    break;
            }
        }
        
        PrintAnimals();
        PrintHungryAnimalsByArea();
    }

    private static int ContainsAnimal(string animal) {
        for (int i = 0; i < animals.Count; i++) {
            if (animals[i].Name == animal) {
                return i;
            }
        }

        return -1;
    }

    private static void AddAnimal(string name, int neededFood, string area) {
        if (ContainsAnimal(name) != -1) {
            animals[ContainsAnimal(name)].NeededFood += neededFood;
            return;
        }
        
        Animal animal = new Animal(name, neededFood, area);
        animals.Add(animal);
    }

    private static void FeedAnimal(string name, int food) {
        if (ContainsAnimal(name) == -1) return;
        
        animals[ContainsAnimal(name)].NeededFood -= food;

        if (animals[ContainsAnimal(name)].NeededFood <= 0) {
            animals.Remove(animals[ContainsAnimal(name)]);
            Console.WriteLine($"{name} was successfully fed");
        }
    }

    private static void PrintAnimals() {
        Console.WriteLine("Animals:");
        foreach (Animal animal in animals) {
            Console.WriteLine($" {animal.Name} -> {animal.NeededFood}g");
        }
    }

    private static void PrintHungryAnimalsByArea() {
        var hungryAnimalsByArea = animals
            .GroupBy(a => a.Area)
            .ToDictionary(g => g.Key, g => g.Count());

        if (hungryAnimalsByArea.Any()) {
            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in hungryAnimalsByArea) {
                Console.WriteLine($" {area.Key}: {area.Value}");
            }
        }
    }
}

class Animal {
    public Animal(string name, int neededFood, string area) {
        Name = name;
        NeededFood = neededFood;
        Area = area;
    }
    
    public string Name { get; set; }
    public int NeededFood { get; set; }
    public string Area { get; set; }
}
