
using System.ComponentModel;

int number = int.Parse(Console.ReadLine());

Dictionary<string, string> register = new Dictionary<string, string>();

for (int i = 0; i < number; i++)
{
    string[] commands = Console.ReadLine()
        .Split(" ")
        .ToArray();

    string user = commands[1];


    if (commands[0] == "register")
    {
        string plateNumber = commands[2];
        if (!register.ContainsKey(user))
        {
            register.Add(user, plateNumber);
            Console.WriteLine($"{user} registered {plateNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
        }
    }
    else
    {
        if (!register.ContainsKey(user))
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
        else
        {
            Console.WriteLine($"{user} unregistered successfully");
            register.Remove(user);
        }
    }
}

foreach (KeyValuePair<string, string> pair in register)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}
