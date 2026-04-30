namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("値1を入力してください->");
        int number1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("値2を入力してください->");
        int number2 = int.Parse(Console.ReadLine()!);
        try
        {
            Console.WriteLine($"値1 / 値2 = {Calculator.Div(x: number1, y: number2)}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0では割り算できません。");
        }
    }
}
