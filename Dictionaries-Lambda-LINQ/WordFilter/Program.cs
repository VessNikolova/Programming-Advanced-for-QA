
string[] arr = Console.ReadLine()
    .Split(" ")
    .ToArray();

for (int i = 0; i < arr.Length; i++)
{
    string word = arr[i];

    if(word.Length % 2 == 0)
    {
        Console.WriteLine(word);
    }
}
