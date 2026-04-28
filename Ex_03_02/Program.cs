Item item1 = new();

Console.WriteLine("商品番号を入力してください->");
item1.itemNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("商品名を入力して下さい->");
item1.itemName = Console.ReadLine();
Console.WriteLine("単価を入力してください->");
item1.price = int.Parse(Console.ReadLine()!);
Print(item1);

static void Print(Item item)
{
    Console.WriteLine("結果");
    Console.WriteLine($"商品番号 = {item.itemNo}");
    Console.WriteLine($"商品名 = {item.itemName}");
    Console.WriteLine($"単価 = {item.price}");
}

public class Item
{
    public int itemNo;
    public string itemName = string.Empty;
    public int price;
}

