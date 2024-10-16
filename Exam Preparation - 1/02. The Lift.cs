using System;
using System.Linq;
using System.Collections.Generic;

class TheLift {
    static void Main() {
        int peoples = int.Parse(Console.ReadLine());
        List<int> lift = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < lift.Count; i++) {
            int peopleToAdd = 4 - lift[i];

            if (peoples < peopleToAdd) {
                lift[i] += peoples;
                peoples = 0; 
            } 
            else {
                lift[i] += peopleToAdd;
                peoples -= peopleToAdd;
            }

            if (peoples <= 0) {
                if (lift.Sum() < lift.Count * 4) {
                    Console.WriteLine("The lift has empty spots!");
                }
                Console.WriteLine(string.Join(" ", lift));
                return;
            }
        }

        Console.WriteLine($"There isn't enough space! {peoples} people in a queue!");
        Console.WriteLine(string.Join(" ", lift));
    }
}

