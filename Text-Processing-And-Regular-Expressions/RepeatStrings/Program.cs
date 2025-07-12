
string[] arr = Console.ReadLine()
    .Split(" ")
    .ToArray();

for (int i = 0; i < arr.Length; i++)
{
    string currentStr = arr[i];

    for (int j = 0; j < currentStr.Length; j++)
    {
        Console.Write(currentStr);
    }
}


