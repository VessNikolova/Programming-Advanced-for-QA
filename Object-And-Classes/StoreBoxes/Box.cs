

namespace StoreBoxes
{
    internal class Box
    {
        //Serial Number, Item, Item Quantity and Price for a Box.
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox
        {
            get
            {
                return Item.Price * ItemQuantity;
            }
        }

        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = quantity;
        }
    }
}
