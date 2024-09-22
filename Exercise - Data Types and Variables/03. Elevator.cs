using System;

class Elevator {
    static void Main() {
        int peopleCount = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        if (peopleCount % capacity == 0) {
            Console.WriteLine(peopleCount / capacity);
        }
        else {
            Console.WriteLine((peopleCount / capacity) + 1);
        }

    }
}