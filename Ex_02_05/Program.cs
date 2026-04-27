namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int value = int.Parse(Console.ReadLine()!);

        if (value % 2 == 0)
        {
            Console.WriteLine($"結果:{value * 10}");
        }
        else
        {
            Console.WriteLine($"結果:{value}");
        }
    }
}
