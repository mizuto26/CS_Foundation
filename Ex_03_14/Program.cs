namespace Ex_03_14;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("値1を入力してください->");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("値2を入力してください->");
        int number2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"加算: {number1.Add(number2)}");
        Console.WriteLine($"平均: {number1.Average(number2)}");
    }
}
