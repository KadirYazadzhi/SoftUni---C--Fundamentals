using System;
using System.Linq;
using System.Collections.Generic;

class MergingLists {
    static void Main() {
        List<double> numbers1 = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> numbers2 = Console.ReadLine().Split().Select(double.Parse).ToList(); 

        List<double> resultNumbers = new List<double>(); 

        int end = 0;
        if (numbers1.Count > numbers2.Count) {
            end = numbers1.Count;
        } 
        else {
            end = numbers2.Count;
        }

        for (int i = 0; i < end; i++) {
            if (numbers1.Count > i) {
                resultNumbers.Add(numbers1[i]);
            }

            if (numbers2.Count > i) {
                resultNumbers.Add(numbers2[i]);
            }
        }
        Console.WriteLine(string.Join(" ", resultNumbers));
    }
}