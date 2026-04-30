namespace Ex_03_11.Modules
{
    public class Mouse : IUSB
    {
        public void SendData()
        {
            Console.WriteLine("PCにマウスの移動情報を送信しました");
        }

        public void ReciveData()
        {
            Console.WriteLine("PCにマウスの移動情報を受信しました");
        }
    }
}