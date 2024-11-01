using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<Vehicle> vehicles = new();

        string data;
        string[] arguments;
        while ((data = Console.ReadLine()) != "End") {
            arguments = data.Split();
            Vehicle veh = new Vehicle(arguments[0], arguments[1], arguments[2], double.Parse(arguments[3]));
            vehicles.Add(veh);
        }

        while ((data = Console.ReadLine()) != "Close the Catalogue") {
            foreach (Vehicle v in vehicles) {
                if (v.Model == data) {
                    Console.WriteLine($"Type: {char.ToUpper(v.Type[0]) + v.Type.Substring(1)}");
                    Console.WriteLine($"Model: {v.Model}");
                    Console.WriteLine($"Color: {v.Color}");
                    Console.WriteLine($"Horsepower: {v.Horsepower}");
                    break; 
                }
            }
        }

        double averageCarHorsePower = vehicles.Where(v => v.Type == "car").Select(v => v.Horsepower).DefaultIfEmpty(0).Average();
        double averageTruckHorsePower = vehicles.Where(v => v.Type == "truck").Select(v => v.Horsepower).DefaultIfEmpty(0).Average();

        Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:F2}.");
        Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:F2}.");
    }
}

class Vehicle {
    public Vehicle(string type, string model, string color, double horsepower) {
        Type = type;
        Model = model;
        Color = color;
        Horsepower = horsepower;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double Horsepower { get; set; }
}
