using Ex_03_07.Models;

Item item1 = new();

Console.WriteLine("商品番号を入力してください->");
item1.itemNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("商品名を入力して下さい->");
item1.itemName = Console.ReadLine()!;
Console.WriteLine("単価を入力してください->");
item1.price = int.Parse(Console.ReadLine()!);
item1.Print();


