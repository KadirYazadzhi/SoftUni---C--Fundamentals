using System;

class Login {
    static string reverse(string name) {
        string reverseName = "";
        
        for (int i = name.Length - 1; i >= 0; i--) {
            reverseName += name[i];
        }

        return reverseName;
    }

    static void isValid(string name) {
        int i = 1;
        while (true) {
             string password = Console.ReadLine();
            if (password == reverse(name)) {
                Console.WriteLine($"User {name} logged in.");
                break;
            }
            
            if (i > 3) {
                Console.WriteLine($"User {name} blocked!");
                break;
            }

            Console.WriteLine("Incorrect password. Try again.");
            i++;
        }
    }

    static void Main() {
        string name = Console.ReadLine();
        isValid(name);
    }
}
