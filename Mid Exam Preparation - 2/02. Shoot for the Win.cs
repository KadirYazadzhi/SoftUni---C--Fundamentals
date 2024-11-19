using System;
using System.Linq;
using System.Collections.Generic;

class ShootForTheWin {
    static void Main() {
        List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
        targets = shootTargets(targets);
        printTargets(targets);
    }

    static List<int> shootTargets(List<int> targets) {
        string command;
        while ((command = Console.ReadLine()) != "End") {
            if (int.Parse(command) >= 0 && int.Parse(command) < targets.Count && targets[int.Parse(command)] != -1) {
                targets = shoot(targets, int.Parse(command));
            }
        }
        return targets;
    }

    static List<int> shoot(List<int> targets, int index) {
        int target = targets[index];
        targets[index] = -1;

        for (int i = 0; i < targets.Count; i++) {
            if (i != index && targets[i] != -1) {
                if (targets[i] > target) {
                    targets[i] -= target;
                }
                else {
                    targets[i] += target;
                }
            }
        }

        return targets;
    }

    static void printTargets(List<int> targets) {
        int shootedTarget = 0;
        foreach (int target in targets) {
            if (target == -1) {
                shootedTarget++;
            }
        }
        Console.WriteLine($"Shot targets: {shootedTarget} -> " + string.Join(" ", targets));
    }
}