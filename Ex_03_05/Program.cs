Console.WriteLine("商品番号を入力してください->");
int pitemNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("商品名を入力して下さい->");
string pitemName = Console.ReadLine()!;
Console.WriteLine("単価を入力してください->");
int price = int.Parse(Console.ReadLine()!);

Item item1 = new(pitemNo: pitemNo, pitemName: pitemName, pprice: price);

Console.WriteLine("結果");

Console.WriteLine($"商品番号 = {item1.itemNo}");
Console.WriteLine($"商品名 = {item1.itemName}");
Console.WriteLine($"単価 = {item1.price}");

public class Item
{
    public int itemNo;
    public string itemName = string.Empty;
    public int price;

    public Item(int pitemNo, string pitemName, int pprice)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }
}
