
        List<string> words = Console.ReadLine()
            .ToLower()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        Dictionary<string, int> counts = new Dictionary<string, int>();
        List<string> order = new List<string>();

        foreach (string word in words)
        {
            if (!counts.ContainsKey(word))
            {
                counts[word] = 1;
                order.Add(word); // track order of first appearance
            }
            else
            {
                counts[word]++;
            }
        }

        foreach (string word in order)
        {
            if (counts[word] % 2 != 0)
            {
                Console.Write(word + " ");
            }
        }

