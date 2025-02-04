namespace GroceryCalculationApp
{
    internal class Item
    {
        public double price;
        public string name;
        public int qty;
        public Item(string name, int qty, double price)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;
        }

    }
}
