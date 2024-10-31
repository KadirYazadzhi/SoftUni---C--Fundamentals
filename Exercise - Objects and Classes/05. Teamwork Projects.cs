using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main() {
        int num = int.Parse(Console.ReadLine());
        List<TeamworkProject> teamProjects = new();

        string data;
        while ((data = Console.ReadLine()) != "end of assignment") {
            string[] commands;
            if (data.Contains("->")) {  
                commands = data.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = commands[0];
                string teamName = commands[1];

                var team = teamProjects.FirstOrDefault(t => t.Name == teamName);
                if (team == null) {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teamProjects.Any(t => t.Members.Contains(user) || t.Creator == user)) {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else {
                    team.Members.Add(user);
                }
            } 
            else { 
                commands = data.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = commands[0];
                string teamName = commands[1];

                if (teamProjects.Any(t => t.Name == teamName)) {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamProjects.Any(t => t.Creator == creator)) {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else {
                    TeamworkProject newTeam = new TeamworkProject(teamName, creator);
                    teamProjects.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        var validTeams = teamProjects
            .Where(t => t.Members.Count > 0)
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name)
            .ToList();

        foreach (var team in validTeams) {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.OrderBy(m => m)) {
                Console.WriteLine($"-- {member}");
            }
        }

  
        var disbandTeams = teamProjects
            .Where(t => t.Members.Count == 0)
            .OrderBy(t => t.Name)
            .ToList();

        Console.WriteLine("Teams to disband:");
        foreach (var team in disbandTeams) {
            Console.WriteLine(team.Name);
        }
    }
}

class TeamworkProject {
    public TeamworkProject(string name, string creator) {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }

    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}
