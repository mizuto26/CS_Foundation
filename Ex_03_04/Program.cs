Item item1 = new();

Console.WriteLine("商品番号を入力してください->");
item1.itemNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("商品名を入力して下さい->");
item1.itemName = Console.ReadLine()!;
Console.WriteLine("単価を入力してください->");
item1.price = int.Parse(Console.ReadLine()!);

Console.WriteLine($"税込み金額={item1.CalculateTaxAmount()}");

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
