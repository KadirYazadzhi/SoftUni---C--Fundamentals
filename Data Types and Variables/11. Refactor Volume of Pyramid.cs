using System;

class VolumeOfPyramid {
    static void Main() {
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        double heigth = double.Parse(Console.ReadLine());

        Console.WriteLine($"Pyramid Volume: {((length * width * heigth) / 3):F2}");
    }
}