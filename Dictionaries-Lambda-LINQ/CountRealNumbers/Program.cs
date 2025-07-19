
List<int> list = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();

SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

for (int i = 0; i < list.Count; i++)
{
    int number = list[i];

    if (!dict.ContainsKey(number))
    {
        dict.Add(number, 1);
    }
    else
    {
        int count = dict[number];
        dict[number] = count + 1;
    }
}

foreach(KeyValuePair<int, int> pair in dict)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
