
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public class Display : ISUB
    {
        public static void SendData()
        {
            Console.WriteLine("ディスプレイに表示する情報を送信しました");
        }

        public static void ReciveData()
        {
            Console.WriteLine("ディスプレイに表示する情報を受信しました");
        }
    }
}