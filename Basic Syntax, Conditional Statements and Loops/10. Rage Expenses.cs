using System;

class RageExpenses {
    static void Main() {
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double totalExpenses = 0;
        int headsetCount = lostGames / 2;
        int mouseCount = lostGames / 3;
        int keyboardCount = lostGames / 6; 
        int displayCount = keyboardCount / 2;

        totalExpenses = (headsetCount * headsetPrice) + 
                        (mouseCount * mousePrice) + 
                        (keyboardCount * keyboardPrice) + 
                        (displayCount * displayPrice);

        Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
    }
}