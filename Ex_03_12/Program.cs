namespace Ex_03_12;

using Ex_03_12.Modules;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DVDのタイトルを入力してください->");
        Player dvd = new DVDPlayer(Console.ReadLine()!);
        dvd.Play();
        dvd.Stop();

        Console.WriteLine("Blurayのタイトルを入力してください->");
        Player bluray = new BlurayPlayer(Console.ReadLine()!);
        bluray.Play();
        bluray.Stop();
    }
}
