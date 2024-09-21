using System;

class CenturiesToMinutes {
    static void Main() {
        int centuries = int.Parse(Console.ReadLine());

        int yearsInCentury = 100;
        double daysInYear = 365.2422;
        int hoursInDay = 24;
        int minutesInHour = 60;

        int years = centuries * yearsInCentury;
        int days = (int)(years * daysInYear);
        int hours = days * hoursInDay;
        int minutes = hours * minutesInHour;

        Console.WriteLine($"{centuries} centuries = {years} years = {days:F0} days = {hours} hours = {minutes} minutes");
    }
}


