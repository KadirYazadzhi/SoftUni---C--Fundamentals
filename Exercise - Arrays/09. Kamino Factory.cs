using System;
using System.Linq;

class KaminoFactory {
    static void Main() {
        int dnaLength = int.Parse(Console.ReadLine());
        string input;
        int[] bestDnaSequence = new int[dnaLength];
        int bestLength = 0;
        int bestIndex = int.MaxValue;
        int bestSum = 0;
        int sampleCounter = 0;
        int bestSample = 0;

        while ((input = Console.ReadLine()) != "Clone them!") {
            sampleCounter++;
            int[] currentSequence = input.Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int currentSum = currentSequence.Sum();
            int currentBestLength = 0;
            int currentBestIndex = -1;

            int tempLength = 0;
            for (int i = 0; i < currentSequence.Length; i++) {
                if (currentSequence[i] == 1) {
                    tempLength++;
                    if (tempLength > currentBestLength) {
                        currentBestLength = tempLength;
                        currentBestIndex = i - tempLength + 1; 
                    }
                }
                else {
                    tempLength = 0;
                }
            }

            bool isCurrentSequenceBetter = false;

            if (currentBestLength > bestLength) {
                isCurrentSequenceBetter = true;
            }
            else if (currentBestLength == bestLength && currentBestIndex < bestIndex) {
                isCurrentSequenceBetter = true;
            }
            else if (currentBestLength == bestLength && currentBestIndex == bestIndex && currentSum > bestSum) {
                isCurrentSequenceBetter = true;
            }

            if (isCurrentSequenceBetter) {
                bestDnaSequence = currentSequence.ToArray(); 
                bestLength = currentBestLength;
                bestIndex = currentBestIndex;
                bestSum = currentSum;
                bestSample = sampleCounter;
            }
        }

        Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
        Console.WriteLine(string.Join(" ", bestDnaSequence));
    }
}
