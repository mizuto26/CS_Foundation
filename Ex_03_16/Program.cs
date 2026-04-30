namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("値1を入力してください->");
            int number1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("値2を入力してください->");
            int number2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"値1 / 値2 = {Calculator.Div(x: number1, y: number2)}");
        }
        catch (InputParameterLessThanZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");
        }

        Console.WriteLine("プログラム正常終了");
    }
}
