namespace Ex_03_11.Modules
{
    public class Mouse : IUSB
    {
        public void SendData()
        {
            throw NotImplementedException;
        }

        public void ReciveData()
        {
            Console.WriteLine("PCにマウスの移動情報を受信しました");
        }
    }
}