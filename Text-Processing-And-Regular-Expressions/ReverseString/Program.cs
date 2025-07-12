

string input = Console.ReadLine();

while(input != "end")
{
    char[] arr = input.ToCharArray();

    Console.WriteLine(input + " = " + String.Join("", arr.Reverse()));

    input = Console.ReadLine();
}

