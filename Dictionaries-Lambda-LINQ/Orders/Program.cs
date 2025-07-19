
using System.Collections.Concurrent;

string input = Console.ReadLine();

Dictionary<string, double> groceryList = new Dictionary<string, double>();

while(input != "buy")
{
    string[] arr = input.Split(" ");
    string product = arr[0];
    double price = double.Parse(arr[1]);
    int quantity = int.Parse(arr[2]);

    if (!groceryList.ContainsKey(product))
    {
        groceryList.Add(product, price * quantity);
    }
    else
    {
        double total = groceryList[product];
        groceryList[product] = total + price * quantity;
    }
        input = Console.ReadLine();
}

foreach(KeyValuePair<string, double> pair in groceryList)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
}
