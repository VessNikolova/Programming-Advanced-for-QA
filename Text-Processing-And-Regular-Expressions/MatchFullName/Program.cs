﻿
using System.Text.RegularExpressions;

string text = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex = new Regex(pattern);

MatchCollection matches = Regex.Matches(text, pattern);

Console.WriteLine(string.Join(" ", matches));

