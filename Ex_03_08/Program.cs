using Ex_03_08.Modules;
NetAccount account = new();

Console.WriteLine("口座番号を入力してください->");
account.accountNo = Console.ReadLine();
Console.WriteLine("口座名義を入力して下さい->");
account.accountName = Console.ReadLine();
Console.WriteLine("残高を入力してください->");
account.balance = int.Parse(Console.ReadLine()!);
Console.WriteLine("ポイントを入力してください->");
account.point = int.Parse(Console.ReadLine()!);

Console.WriteLine($"口座番号 = {account.accountNo}");
Console.WriteLine($"口座名義 = {account.accountName}");
Console.WriteLine($"残高 = {account.balance}");
Console.WriteLine($"残高 = {account.point}");






