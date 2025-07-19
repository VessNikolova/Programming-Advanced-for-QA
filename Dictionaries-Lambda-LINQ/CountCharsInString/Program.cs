
char[] input = Console.ReadLine()
    .ToCharArray();

Dictionary<char, int> dict = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char currentSymbol = input[i];

    if (currentSymbol != ' ' && (!dict.ContainsKey(currentSymbol)))
    {
        dict.Add(currentSymbol, 1);
    }
    else if (currentSymbol != ' ' && dict.ContainsKey(currentSymbol))
    {
        int count = dict[currentSymbol];
        dict[currentSymbol] = count + 1;
    }
}

foreach (KeyValuePair<char, int> pair in dict)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}

