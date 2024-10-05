using System;

class RectangleArea {
    static void Main() {
        Console.WriteLine(calculateRectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
    }

    static double calculateRectangleArea(double width, double height) {
        return width * height;
    }
}