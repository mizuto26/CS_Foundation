namespace Ex_03_06
{
    public class Item
    {
        public int itemNo;
        public string itemName = string.Empty;
        public int price;

        public Item() { }

        public void ChangePrice(string pprice)
        {
            ChangePrice(int.Parse(pprice));
        }

        public void ChangePrice(int pprice)
        {
            price = pprice;
        }
    }
}