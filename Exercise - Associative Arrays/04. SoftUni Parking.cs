using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        Dictionary<string, string> parkingInfo = new();

        for (int i = 0; i < num; i++) {
            string[] arguments = Console.ReadLine().Split().ToArray();

            switch (arguments[0]) {
                case "register":
                    if (!parkingInfo.ContainsKey(arguments[1])) {
                        parkingInfo.Add(arguments[1], arguments[2]);
                        Console.WriteLine($"{arguments[1]} registered {arguments[2]} successfully");
                        continue;
                    }
                    Console.WriteLine($"ERROR: already registered with plate number {parkingInfo[arguments[1]]}");
                break;

                case "unregister":
                    if (!parkingInfo.ContainsKey(arguments[1])) {
                        Console.WriteLine($"ERROR: user {arguments[1]} not found");
                        continue;
                    }
                    parkingInfo.Remove(arguments[1]);
                    Console.WriteLine($"{arguments[1]} unregistered successfully");
                break;
            }
        }

        foreach ((string name, string number) in parkingInfo) {
            Console.WriteLine($"{name} => {number}");
        }
    }
}