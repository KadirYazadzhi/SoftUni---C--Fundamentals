using System;
using System.Linq;
using System.Collections.Generic;

internal class PokemonDontGo {
    static void Main() {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0;

        while (list.Count > 0) {
            int number = int.Parse(Console.ReadLine());

            if (number < 0) {
                sum += list[0];
                ModifyList(list, list[0]);
                list[0] = list[list.Count - 1];
            } 
            else if (number >= list.Count) {
                sum += list[list.Count - 1];
                ModifyList(list, list[list.Count - 1]);
                list[list.Count - 1] = list[0];
            }
            else {
                int currentValue = list[number]; 
                sum += currentValue;
                ModifyList(list, currentValue);
                list.RemoveAt(number);
            }
        }

        Console.WriteLine(sum);
    }

    static void ModifyList(List<int> list, int value) {
        for (int i = 0; i < list.Count; i++) {
            if (list[i] <= value) {
                list[i] += value;
            } 
            else {
                list[i] -= value;
            }
        }
    }
}
