using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    public static List<Hero> heroes = new List<Hero>();
    
    public static void Main() {
        ReadData();
        ReadCommands();
    }

    private static void ReadData() {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Hero hero = new Hero(line[0], int.Parse(line[1]), int.Parse(line[2]));
            
            heroes.Add(hero);
        }
    }

    private static void ReadCommands() {
        string line = null;
        while ((line = Console.ReadLine()) != "End") {
            string[] commands = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            int index = heroes.FindIndex(x => x.Name == commands[1]);
            
            switch (commands[0]) {
                case "CastSpell":
                    CastSpell(commands[1], int.Parse(commands[2]), commands[3], index);
                    break;
                case "TakeDamage":
                    TakeDamage(commands[1], int.Parse(commands[2]), commands[3], index);
                    break;
                case "Recharge":
                    Recharge(commands[1], int.Parse(commands[2]), index);
                    break;
                case "Heal":
                    Heal(commands[1], int.Parse(commands[2]), index);
                    break;
            }
        }
        PrintHeroes();
    }

    private static void CastSpell(string heroName, int mp, string spellName, int index) {
        if (heroes[index].MP < mp) {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            return;
        }
        
        heroes[index].MP -= mp;
        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[index].MP} MP!");
    }

    private static void TakeDamage(string heroName, int damage, string attacker, int index) {
        heroes[index].HP -= damage;

        if (heroes[index].HP <= 0) {
            heroes.RemoveAt(index);
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
            return;
        }
        
        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[index].HP} HP left!");
    }

    private static void Recharge(string heroName, int amount, int index) {
        int rechargeAmount = Math.Min(amount, 200 - heroes[index].MP);
        heroes[index].MP += rechargeAmount;
        Console.WriteLine($"{heroName} recharged for {rechargeAmount} MP!");
    }

    private static void Heal(string heroName, int amount, int index) {
        int healedAmount = Math.Min(amount, 100 - heroes[index].HP);
        heroes[index].HP += healedAmount;
        Console.WriteLine($"{heroName} healed for {healedAmount} HP!");
    }

    private static void PrintHeroes() {
        foreach ((string name, int hp, int mp) in heroes) {
            Console.WriteLine(name);
            Console.WriteLine($"  HP: {hp}");
            Console.WriteLine($"  MP: {mp}");
        }
    }
}

public class Hero {
    public void Deconstruct(out string name, out int hp, out int mp) {
        name = Name;
        hp = HP;
        mp = MP;
    }
    
    public Hero(string name, int hp, int mp) {
        Name = name;
        HP = hp;
        MP = mp;
    }
    
    public string Name { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }
}


