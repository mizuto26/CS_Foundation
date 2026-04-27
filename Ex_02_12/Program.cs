namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("値を入力して下さい->");
        int number = Mul3(int.Parse(Console.ReadLine()!));
        Console.Write(number);
    }

    static int Mul3(int value)
    {
        return value * 3;
    }
}
