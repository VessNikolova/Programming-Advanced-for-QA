
namespace StoreBoxes
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();

            while(input != "end")
            {
                string[] commands = input.Split(" ");
                string serialNumber = commands[0];
                string itemName = commands[1];
                int quantity = int.Parse(commands[2]);
                double price = double.Parse(commands[3]);

                Item item = new Item(itemName, price);
                items.Add(item);

                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (Box box in boxes.OrderByDescending(b => b.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }

        }
    }
}
