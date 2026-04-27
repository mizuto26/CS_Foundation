namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[3];

        Console.WriteLine("数値1を入力してください->");
        array[0] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("数値2を入力してください->");
        array[1] = int.Parse(Console.ReadLine()!);
        Console.WriteLine("数値3を入力してください->");
        array[2] = int.Parse(Console.ReadLine()!);

        Console.WriteLine("入力結果");

        Console.Write($"数値1:{array[0]}\n");
        Console.Write($"数値2:{array[1]}\n");
        Console.Write($"数値3:{array[2]}\n");
    }
}
