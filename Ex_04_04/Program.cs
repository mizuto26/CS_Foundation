using Ex_04_04.Modules;
namespace Ex_04_04;

static class Program
{
    static void Main(string[] args)
    {
        var items = new Dictionary<int, Item>
        {
            { 101, new Item(id: 101, name: "水性ボールペン(黒)", price: 150) },
            { 102, new Item(id: 102, name: "油性ボールペン(黒)", price: 100) },
            { 103, new Item(id: 103, name: "鉛筆(黒)", price: 60) },
            { 104, new Item(id: 104, name: "鉛筆(赤)", price: 80) }
        };

        Console.WriteLine("商品番号を入力してください->");
        int key = int.Parse(Console.ReadLine()!);
        bool isContainsKey = items.ContainsKey(key);

        if (isContainsKey)
        {
            Console.WriteLine($"{items[key].ToString()}");
        }
        else
        {
            Console.WriteLine("該当する商品がありません。");
        }
    }
}
