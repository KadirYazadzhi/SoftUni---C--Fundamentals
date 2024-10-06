using System;

class ArrayManipulator {
    static void Main() {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string command;
        while((command = Console.ReadLine()) != "End") {
            string[] arguments = command.Split();

            switch (arguments[0]) {
                case "exchange":
                    int index = int.Parse(arguments[1]);
                    numbers = Exchange(numbers, index);
                    break;
                case "max":
                    string maxType = arguments[1];
                    PrintMaxIndex(numbers, maxType);
                    break;
                case "min":
                    string minType = arguments[1];
                    PrintMinIndex(numbers, minType);
                    break;
                case "first":
                    int firstCount = int.Parse(arguments[1]);
                    string firstType = arguments[2];
                    PrintFirstElement(numbers, firstCount, firstType);
                    break;
                case "last":
                    int lastCount = int.Parse(arguments[1]);
                    string lastType = arguments[2];
                    PrintLastElement(numbers, lastCount, lastType);
                    break;
            }
        }
    }

    static bool isValidIndex(int index, int end) {
        return index >= 0 && index < end;
    }


    static int[] Exchange(int[] numbers, int index) {
        if (!isValidIndex(index, numbers.Length)) {
            Console.WriteLine("Invalid index");
            return numbers;
        }

        int[] changedArr = new int[numbers.Length];
        int changedArrIndex = 0;

        for (int i = index + 1; i < numbers.Length; i++) {
            changedArr[changedArrIndex] = numbers[i];
            changedArrIndex++;
        } 

        for (int i = 0; i <= index; i++) {
            changedArr[changedArrIndex] = numbers[i];
            changedArrIndex++;
        }

        return changedArr;
    }

    static void PrintLastElement(int[] numbers, int count, string type) {
        if (count > numbers.Length) {
            Console.WriteLine("Invalid count");
            return;
        }

        string lastElementsResult = "";
        int elementsCount = 0;

        for (int i = numbers.Length - 1; i >= 0 ; i++) {
            int number = numbers[i];

            if (isValidForEvenOrOdd(type, number)) {
                lastElementsResult = $"{number}, " + lastElementsResult;
                elementsCount++;
                if (elementsCount >= count) {
                    break;
                }
            }
        }

        lastElementsResult = lastElementsResult.Trim(' ', ',');
        Console.WriteLine($"[{lastElementsResult}]");
    }

    static void PrintFirstElement(int[] numbers, int count, string type) {
        if (count > numbers.Length) {
            Console.WriteLine("Invalid count");
            return;
        }

        string firstElementsResult = "";
        int elementsCount = 0;

        for (int i = 0; i < numbers.Length; i++) {
            int number = numbers[i];

            if (isValidForEvenOrOdd(type, number)) {
                firstElementsResult += $"{number}, ";
                elementsCount++;
                if (elementsCount >= count) {
                    break;
                }
            }
        }

        firstElementsResult = firstElementsResult.Trim(' ', ',');
        Console.WriteLine($"[{firstElementsResult}]");
    }

    static void PrintMinIndex(int[] numbers, string type) {
        int minIndex = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++) {
            int number = numbers[i];

            if (isValidForEvenOrOdd(type, number)) {
                if (number <= maxNumber) {
                    minIndex = i;
                    minNumber = number;
                }
            }
        }

        indexIsChange(index);
    }

    static void PrintMaxIndex(int[] numbers, string type) {
        int maxIndex = -1;
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.Length; i++) {
            int number = numbers[i];

            if (isValidForEvenOrOdd(type, number)) {
                if (number >= maxNumber) {
                    maxIndex = i;
                    maxNumber = number;
                }
            }
        }

        indexIsChange(index);
    }
    
    static void indexIsChange(int index) {
        if (index != -1) {
            Console.WriteLine(maxIndex);
        }
        else {
            Console.WriteLine("No matches");
        }
    }

    static bool isValidForEvenOrOdd(string type, int number) {
        return type == "odd" && number % 2 != 0 || type == "even" && number % 2 == 0;
    }
}