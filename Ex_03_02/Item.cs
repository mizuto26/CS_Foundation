namespace Ex_03_02
{
    public class Item
    {
        public int itemNo;
        public string itemName = string.Empty;
        public int price;

        public void Print()
        {
            Console.WriteLine("結果");
            Console.WriteLine($"商品番号 = {itemNo}");
            Console.WriteLine($"商品名 = {itemName}");
            Console.WriteLine($"単価 = {price}");
        }
    }
}