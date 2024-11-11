using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        List<char> characters = Console.ReadLine().ToCharArray().ToList();
        int power = 0;  
        
        for (int i = 0; i < characters.Count; i++) {
            if (characters[i] == '>') {
                power += (int)char.GetNumericValue(characters[i + 1]);
            } 
            else if (power > 0) { 
                characters.RemoveAt(i);
                power--;
                i--; 
            }
        }

        Console.WriteLine(string.Join("", characters));
    }
}

