using Ex_03_08.Modules;
NetAccount account = new();

Console.WriteLine("口座番号を入力してください->");
account.AccountNo = Console.ReadLine();
Console.WriteLine("口座名義を入力して下さい->");
account.AccountName = Console.ReadLine();
Console.WriteLine("残高を入力してください->");
account.Balance = int.Parse(Console.ReadLine()!);
Console.WriteLine("ポイントを入力してください->");
account.Point = int.Parse(Console.ReadLine()!);

Console.WriteLine($"口座番号 = {account.AccountNo}");
Console.WriteLine($"口座名義 = {account.AccountName}");
Console.WriteLine($"残高 = {account.Balance}");
Console.WriteLine($"残高 = {account.Point}");






