using System;

class Program {

    static void Main() {
        char[] characters = Console.ReadLine().ToCharArray();

        characters = Encryption(characters);
        
        Console.WriteLine(new string(characters));
    }

    static char[] Encryption(char[] characters) {
        for (int i = 0; i < characters.Length; i++) {
            characters[i] = (char)((int)(characters[i] + 3));
            
            if (characters[i] == ' ') {
                characters[i] = '#';
            }
        }
        
        return characters;
    }
}
