using Ex_03_09.Modules;

Console.WriteLine("口座番号を入力してください->");
string accountNo = Console.ReadLine()!;
Console.WriteLine("口座名義を入力して下さい->");
string accountName = Console.ReadLine()!;
Console.WriteLine("残高を入力してください->");
int balance = int.Parse(Console.ReadLine()!);
Console.WriteLine("ポイントを入力してください->");
int point = int.Parse(Console.ReadLine()!);

NetAccount netaccount = new(accountNo: accountNo,
                            accountName: accountName,
                            balance: balance,
                            point: point);

netaccount.Print();

