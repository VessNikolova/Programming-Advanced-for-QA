﻿
string firstWord = Console.ReadLine();
string secondWord = Console.ReadLine();

int index = secondWord.IndexOf(firstWord);

while(index != -1)
{
    secondWord = secondWord.Remove(index, firstWord.Length);
    index = secondWord.IndexOf(firstWord);
}

Console.WriteLine(secondWord);
