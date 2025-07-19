
string input = Console.ReadLine();

Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

while(input != "End")
{
    string[] commands = input.Split(" -> ");

    string company = commands[0];
    string id = commands[1];

    if (!register.ContainsKey(company))
    {
        register.Add(company, new List<string>());
        register[company].Add(id);
    }
    else
    {
        if (!register[company].Contains(id))
        {
            register[company].Add(id);
        }
    }

        input = Console.ReadLine();
}

register.ToList().ForEach(pair =>
{
    Console.WriteLine(pair.Key);
    pair.Value.ForEach(id => Console.WriteLine($"-- {id}"));
});

//Easy:
//foreach (KeyValuePair<string, List<string>> pair in register)
//{
//    List<string> ids = pair.Value;

//    Console.WriteLine(pair.Key);
//    ids.ForEach(id => Console.WriteLine($"-- {id}"));
//}
