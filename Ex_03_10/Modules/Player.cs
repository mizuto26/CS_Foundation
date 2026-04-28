using System;

namespace Ex_03_10.Modules
{
    public abstract class Player(string media)
    {
        public string Media = media;

        public abstract void Play();
        public abstract void Stop();
    }
}
