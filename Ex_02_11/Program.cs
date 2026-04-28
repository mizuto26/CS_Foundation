namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string[] values = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        Console.WriteLine("駅名を入力してください->");
        string? name = Console.ReadLine();

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == name)
            {
                continue;
            }
            Console.WriteLine(values[i]);
        }
    }
}
