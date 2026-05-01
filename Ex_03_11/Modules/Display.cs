namespace Ex_03_11.Modules
{
    public class Display : IUSB
    {
        public void SendData()
        {
            Console.WriteLine("ディスプレイに表示する情報を送信しました");
        }

        public void ReciveData()
        {
            throw NotImplementedException;
        }
    }
}