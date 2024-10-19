using System;

class CookingMasterclass {
    static void Main() {
        double budget = double.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        double priceFlour = double.Parse(Console.ReadLine());
        double priceEgg = double.Parse(Console.ReadLine());
        double priceApron = double.Parse(Console.ReadLine());

        int freePackets = studentsCount / 5;

        double sum = (priceApron * Math.Ceiling(studentsCount * 1.2)) + (priceFlour * (studentsCount - freePackets)) + (priceEgg * 10 * studentsCount);

        if (budget >= sum) {
            Console.WriteLine($"Items purchased for {sum:F2}$.");
        }
        else {
            Console.WriteLine($"{sum - budget:F2}$ more needed.");
        }
    }
}