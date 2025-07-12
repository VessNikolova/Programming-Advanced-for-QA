
using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"(?<day>\d{2})(?<separator>[.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";

Regex regex = new Regex(pattern);

MatchCollection matches = Regex.Matches(text, pattern);

char[] symbols = new char[] { '.', '-', '/' };

foreach (Match match in matches)
{
    string[] currentDate = match.Value.Split(symbols);

    Console.WriteLine($"Day: {currentDate[0]}, Month: {currentDate[1]}, Year: {currentDate[2]}");
}

