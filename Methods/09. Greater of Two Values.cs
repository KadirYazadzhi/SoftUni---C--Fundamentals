using System;

class GreaterOfTwoValues {
    static void Main() {
        Console.WriteLine(calculate(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
    }

    static object calculate(string type, string first, string second) {
        switch(type) {
            case "int":;
                return Math.Max(int.Parse(second), int.Parse(first));

            case "char":
                return char.Parse(first) > char.Parse(second) ? char.Parse(first) : char.Parse(second);

            case "string":
                return string.Compare(first, second) > 0 ? first : second;

            default:
                throw new ArgumentException("Invalid type");
        }
    }
}
