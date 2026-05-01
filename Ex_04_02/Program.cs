namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("年を入力して下さい->");
        int year = int.Parse(Console.ReadLine()!);
        bool IsLeapYear = DateTime.IsLeapYear(year);
        if (IsLeapYear)
        {
            Console.WriteLine($"{year}年は閏年です。");
        }
        else
        {
            Console.WriteLine($"{year}年は閏年ではありません。");
        }
    }
}
