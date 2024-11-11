using System;
using System.Collections.Generic;
using System.Linq;

class Program {

    static void Main() {
        List<string> list = Console.ReadLine().Split('\\').ToList();
        
        string[] fileNameAndExtension = list[list.Count - 1].Split('.').ToArray();
        
        Console.WriteLine($"File name: {fileNameAndExtension[0]}");
        Console.WriteLine($"File extension: {fileNameAndExtension[1]}");
    }
}

