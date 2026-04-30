using Ex_03_07.Modules;

Item item1 = new();

Console.WriteLine("商品番号を入力してください->");
item1.ItemNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("商品名を入力して下さい->");
item1.ItemName = Console.ReadLine()!;
Console.WriteLine("単価を入力してください->");
item1.Price = int.Parse(Console.ReadLine()!);

item1.Print();


