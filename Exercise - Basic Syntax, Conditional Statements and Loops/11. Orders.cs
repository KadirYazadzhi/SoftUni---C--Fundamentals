using System;

class RageExpenses {
    static void Main() {
        int num = int.Parse(Console.ReadLine()); 
        double sum = 0; 

        for (int i = 0; i < num; i++) {
            double price = double.Parse(Console.ReadLine()); 
            int days = int.Parse(Console.ReadLine()); 
            int count = int.Parse(Console.ReadLine()); 

            double currentPrice = price * days * count; 
            sum += currentPrice; 
            Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
        }

        Console.WriteLine($"Total: ${sum:F2}"); 
    }
}
