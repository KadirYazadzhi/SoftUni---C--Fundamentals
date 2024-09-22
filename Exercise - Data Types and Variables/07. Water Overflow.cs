using System;

class WaterOverflows {
    static void Main() {
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < num; i++) {
            int liters = int.Parse(Console.ReadLine());

            if (sum + liters > 255) {
                Console.WriteLine("Insufficient capacity!");
            }
            else {
                sum += liters;
            }
        }
        Console.WriteLine(sum);
    } 
}