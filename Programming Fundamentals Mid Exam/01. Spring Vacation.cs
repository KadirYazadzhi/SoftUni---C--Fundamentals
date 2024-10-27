using System;

class TravelExpenses {
    static void Main() {
        int days = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        int numberOfPeople = int.Parse(Console.ReadLine());
        double fuelPricePerKilometer = double.Parse(Console.ReadLine());
        double foodExpensesPerPersonPerDay = double.Parse(Console.ReadLine());
        double hotelPricePerNightPerPerson = double.Parse(Console.ReadLine());

        double[] dailyDistances = new double[days];
        for (int i = 0; i < days; i++) {
            dailyDistances[i] = double.Parse(Console.ReadLine());
        }

        double totalFoodExpenses = foodExpensesPerPersonPerDay * numberOfPeople * days;
        double totalAccommodationExpenses = hotelPricePerNightPerPerson * numberOfPeople * days;

        if (numberOfPeople > 10) {
            totalAccommodationExpenses *= 0.75; 
        }

        double currentExpenses = totalFoodExpenses + totalAccommodationExpenses;

        for (int day = 1; day <= days; day++) {
            currentExpenses += dailyDistances[day - 1] * fuelPricePerKilometer;

            if (day % 3 == 0 || day % 5 == 0) {
                currentExpenses += currentExpenses * 0.40;
            }

            if (day % 7 == 0) {
                currentExpenses -= currentExpenses / numberOfPeople;
            }

            if (currentExpenses > budget) {
                Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses - budget:F2}$ more.");
                return;
            }
        }

        Console.WriteLine($"You have reached the destination. You have {budget - currentExpenses:F2}$ budget left.");
    }
}
