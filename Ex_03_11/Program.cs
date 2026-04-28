namespace Ex_03_11;

using Ex_03_11.Modules;

static class Program
{
    static void Main(string[] args)
    {
        Display display = new();
        FlashMemory flashMemory = new();
        Mouse mouse = new();

        flashMemory.SendData();
        flashMemory.ReciveData();
        mouse.SendData();
        display.ReciveData();
    }
}
