

namespace TeamWorkProjects
{
    internal class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<User> Users { get; set; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Users = new List<User>();
        }

    }
}
