using System;

class PadawanEquipment {
    static void Main() {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int countOfStudents = int.Parse(Console.ReadLine());
        double priceOfLightsabers = double.Parse(Console.ReadLine());
        double priceOfRobes = double.Parse(Console.ReadLine());
        double priceOfBelts = double.Parse(Console.ReadLine());

        int free = 0;
        for (int i = 1; i <= countOfStudents; i++) {
            if (i % 6 == 0) {
                free++;
            } 
        }

        double sum = priceOfLightsabers * Math.Ceiling(countOfStudents * 1.1) +
         priceOfRobes * countOfStudents + 
         priceOfBelts * (countOfStudents - free);

        if (sum <= amountOfMoney) {
            Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
        } 
        else {
            Console.WriteLine($"John will need {(sum - amountOfMoney):F2}lv more.");
        }
    }
}