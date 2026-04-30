namespace Ex_03_04
{
    public class Item
    {
        public int itemNo;
        public string itemName = string.Empty;
        public int price;
        public double salesTaxRate = 0.10;

        public int CalculateTaxAmount()
        {
            return (int)(item1.price * (1.0 + item1.salesTaxRate));
        }
    }
}