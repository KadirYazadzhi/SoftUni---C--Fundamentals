using System;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandArgs = command.Split();

            switch (commandArgs[0])
            {
                case "exchange":
                    int index = int.Parse(commandArgs[1]);
                    numbers = Exchange(numbers, index);
                    break;
                case "max":
                    string maxType = commandArgs[1];
                    PrintMaxIndex(numbers, maxType);
                    break;
                case "min":
                    string minType = commandArgs[1];
                    PrintMinIndex(numbers, minType);
                    break;
                case "first":
                    int firstCount = int.Parse(commandArgs[1]);
                    string firstType = commandArgs[2];
                    PrintFirstElements(numbers, firstCount, firstType);
                    break;
                case "last":
                    int lastCount = int.Parse(commandArgs[1]);
                    string lastType = commandArgs[2];
                    PrintLastElements(numbers, lastCount, lastType);
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static int[] Exchange(int[] numbers, int index)
    {
        if (index < 0 || index >= numbers.Length)
        {
            Console.WriteLine("Invalid index");
            return numbers;
        }

        int[] exchanged = new int[numbers.Length];
        int newIndex = 0;

        for (int i = index + 1; i < numbers.Length; i++)
        {
            exchanged[newIndex++] = numbers[i];
        }

        for (int i = 0; i <= index; i++)
        {
            exchanged[newIndex++] = numbers[i];
        }

        return exchanged;
    }

    static void PrintMaxIndex(int[] numbers, string type)
    {
        int maxIndex = -1;
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsValidType(numbers[i], type) && numbers[i] >= maxNumber)
            {
                maxNumber = numbers[i];
                maxIndex = i;
            }
        }

        if (maxIndex != -1)
        {
            Console.WriteLine(maxIndex);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    static void PrintMinIndex(int[] numbers, string type)
    {
        int minIndex = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsValidType(numbers[i], type) && numbers[i] <= minNumber)
            {
                minNumber = numbers[i];
                minIndex = i;
            }
        }

        if (minIndex != -1)
        {
            Console.WriteLine(minIndex);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    static void PrintFirstElements(int[] numbers, int count, string type)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int[] result = numbers.Where(n => IsValidType(n, type)).Take(count).ToArray();
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static void PrintLastElements(int[] numbers, int count, string type)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        int[] result = numbers.Where(n => IsValidType(n, type)).Reverse().Take(count).Reverse().ToArray();
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    static bool IsValidType(int number, string type)
    {
        if (type == "even")
        {
            return number % 2 == 0;
        }
        else if (type == "odd")
        {
            return number % 2 != 0;
        }

        return false;
    }
}
