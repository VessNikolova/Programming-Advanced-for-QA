
int number = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

for (int i = 0; i < number; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!dict.ContainsKey(word))
    {
        dict.Add(word, new List<string>());
        dict[word].Add(synonym);
    }
    else
    {
        dict[word].Add(synonym);
    }
}

foreach (KeyValuePair<string, List<string>> pair in dict)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}
