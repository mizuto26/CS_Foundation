namespace Ex_03_10;

using Ex_03_10.Modules;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DVDのタイトルを入力してください->");

        DVDPlayer dvdplayer = new(Console.ReadLine()!);
        dvdplayer.Play();
        dvdplayer.Stop();

        Console.WriteLine("Blurayのタイトルを入力してください->");

        BlurayPlayer blurayplayer = new(Console.ReadLine()!);
        blurayplayer.Play();
        blurayplayer.Stop();
    }
}
