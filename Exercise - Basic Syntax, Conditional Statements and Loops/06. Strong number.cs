using System;

class StrongNumbers {
    static bool isStrong(int num) {
        string numbers = num.ToString();
        int result = 0; 

        for (int i = 0; i < numbers.Length; i++) {
            int digit = int.Parse(numbers[i].ToString()); 
            int sum = 1;

            for (int j = 1; j <= digit; j++) {
                sum *= j;
            }

            result += sum;
        }

        return result == num;
    }

    static void Main() {
        int num = int.Parse(Console.ReadLine());

        if (isStrong(num)) {
            Console.WriteLine("yes");
        } else {
            Console.WriteLine("no");
        }
    }
}

