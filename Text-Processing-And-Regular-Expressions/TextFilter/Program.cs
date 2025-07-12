
string[] bannedWords = Console.ReadLine()
    .Split(", ")
    .ToArray();

string text = Console.ReadLine();

for (int i = 0; i < bannedWords.Length; i++)
{
    string currentBannedWord = bannedWords[i];

    text = text.Replace(currentBannedWord, string.Concat(Enumerable.Repeat("*", currentBannedWord.Length)));
}

Console.WriteLine(text);