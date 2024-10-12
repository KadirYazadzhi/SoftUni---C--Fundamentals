using System;
using System.Linq;
using System.Collections.Generic;

class CardGames {
    static void Main() {
        List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0) {
            if (firstPlayerCards[0] > secondPlayerCards[0]) {
                firstPlayerCards.Add(firstPlayerCards[0]);
                firstPlayerCards.RemoveAt(0);

                firstPlayerCards.Add(secondPlayerCards[0]);
                secondPlayerCards.RemoveAt(0);
            }
            else if (firstPlayerCards[0] < secondPlayerCards[0]) {
                secondPlayerCards.Add(secondPlayerCards[0]);
                secondPlayerCards.RemoveAt(0);

                secondPlayerCards.Add(firstPlayerCards[0]);
                firstPlayerCards.RemoveAt(0);
            }
            else {
                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);
            }
        }
        
        if (firstPlayerCards.Count > 0) {
            Console.WriteLine($"First player wins! Sum: {sumCards(firstPlayerCards)}");
        }
        else if (secondPlayerCards.Count > 0) {
            Console.WriteLine($"Second player wins! Sum: {sumCards(secondPlayerCards)}");
        }
    }

    static int sumCards (List<int> cards) {
        int sum = 0;
        foreach (int card in cards) {
            sum += card;
        }
        return sum;
    }
}
