namespace Ex_03_12.Modules
{
    public abstract class Player(string media)
    {
        public string Media = media;

        public abstract void Play();
        public abstract void Stop();

        public void UseMachine()
        {
            this.Play();
            this.Stop();
        }
    }
}
