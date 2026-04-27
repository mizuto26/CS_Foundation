namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int value = int.Parse(Console.ReadLine()!);
        Console.Write($"5を加算した結果は{value + 5}です");
        Console.Write($"5を減算した結果は{value - 5}です");
    }
}
