using System;
using System.Linq;

class RoundingNumbers {
    static void Main() {
        double[] arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

        foreach (double num in arr) {
            int roundedNum = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num} => {roundedNum}");
        }
    }
}