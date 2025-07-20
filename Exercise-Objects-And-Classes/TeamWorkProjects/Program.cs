

namespace TeamWorkProjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                string creator = input[0];
                string teamName = input[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string command = Console.ReadLine();

            while(command != "end of assignment")
            {
                string[] commands = command.Split("->");

                string userName = commands[0];
                string teamToJoin = commands[1];
                Team team = teams.FirstOrDefault(t => t.Name == teamToJoin);

                // Team does not exist
                if (team == null)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }

                // User already in any team (creator or member)
                bool isAlreadyInTeam = teams.Any(t => t.Creator == userName || t.Users.Any(u => u.Name == userName));

                if (isAlreadyInTeam)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamToJoin}!");
                    command = Console.ReadLine();
                    continue;
                }

                // Add user
                team.Users.Add(new User(userName));


                command = Console.ReadLine();
            }

            // Teams with members
            List<Team> validTeams = teams
                .Where(t => t.Users.Count > 0)
                .OrderByDescending(t => t.Users.Count)
                .ThenBy(t => t.Name)
                .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Users.OrderBy(u => u.Name))
                {
                    Console.WriteLine($"-- {member.Name}");
                }
            }

            // Teams to disband (no members)
            List<string> disbandedTeams = teams
                  .Where(t => t.Users.Count == 0)
                  .OrderBy(t => t.Name)
                  .Select(t => t.Name)
                  .ToList();

            Console.WriteLine("Teams to disband:");
            foreach (string name in disbandedTeams)
            {
                Console.WriteLine(name);
            }
        }

    }

}