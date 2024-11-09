using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        string line = Console.ReadLine();
        string digit = null;
        string letters = null;
        string other = null;

        for (int i = 0; i < line.Length; i++) {
            if (Char.IsDigit(line[i])) {
                digit += line[i].ToString();
            }
            else if (Char.IsLetter(line[i])) {
                letters += line[i].ToString();
            }
            else {
                other += line[i].ToString();
            }
        }
        
        Console.WriteLine(digit);
        Console.WriteLine(letters);
        Console.WriteLine(other);
    }
}

