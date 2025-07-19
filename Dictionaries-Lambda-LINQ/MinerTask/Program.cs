
string input = Console.ReadLine();

Dictionary<string, int> mining = new Dictionary<string, int>();

while(input != "stop")
{
    string resource = input;
    int quantity = int.Parse(Console.ReadLine());

    if (!mining.ContainsKey(resource))
    {
        mining.Add(resource, quantity);
    }
    else
    {
        int total = mining[resource];
        mining[resource] = total + quantity;
    }
        input = Console.ReadLine();
}

foreach (KeyValuePair<string, int> pair in mining)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
