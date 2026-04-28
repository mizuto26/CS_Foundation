using System;

namespace Ex_03_10.Modules
{
    public class DVDPlayer(string media)
    : Player(media)
    {
        public override void Play()
        {
            Console.WriteLine($"DVD:{Media}を再生しています");
        }

        public override void Stop()
        {
            Console.WriteLine($"DVD:{Media}の再生を停止しました");
        }
    }
}
