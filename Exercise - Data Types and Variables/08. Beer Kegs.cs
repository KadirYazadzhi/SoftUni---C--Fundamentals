using System;

class BeerKegs {
    static void Main() {
        int num = int.Parse(Console.ReadLine());

        double sumOfTheBiggest = -2147483648;
        string nameOfTheBiggest = "";

        for (int i = 0; i < num; i++) {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            if ((double)(Math.PI * radius * radius * height) > sumOfTheBiggest) {
                sumOfTheBiggest = (double)(Math.PI * radius * radius * height);
                nameOfTheBiggest = model;
            }
        }
        Console.WriteLine(nameOfTheBiggest);
    } 
}