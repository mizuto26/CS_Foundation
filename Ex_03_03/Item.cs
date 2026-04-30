namespace Ex_03_03
{
    public class Item
    {
        public int itemNo;
        public string itemName = string.Empty;
        public int price;

        public static void ChangePrice(int pprice)
        {
            item1.price = pprice;
        }
    }
}