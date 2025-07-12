
using System.Text;

char[] arr = Console.ReadLine().ToCharArray();

StringBuilder digits = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder others = new StringBuilder();

for (int i = 0; i < arr.Length; i++)
{
    char currectChar = arr[i];

    if (char.IsDigit(currectChar))
    {
        digits.Append(currectChar);
    }else if (char.IsLetter(currectChar))
    {
        letters.Append(currectChar);
    }
    else
    {
        others.Append(currectChar);
    }
}

Console.WriteLine(digits.ToString());
Console.WriteLine(letters.ToString());
Console.WriteLine(others.ToString());