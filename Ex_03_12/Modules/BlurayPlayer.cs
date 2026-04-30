namespace Ex_03_12.Modules
{
    public class BlurayPlayer(string media)
    : Player(media)
    {
        public override void Play()
        {
            Console.WriteLine($"Blu-ray:{Media}を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine($"Blu-ray:{Media}の再生を停止しました");
        }
    }
}
