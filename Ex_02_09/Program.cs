namespace Ex_02_09;

static class Program
{
    static void Main(string[] args)
    {
        string[] value = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };

        for (int i = 0; i < value.Length; i++)
        {
            Console.WriteLine(value[i]);
        }
    }
}
