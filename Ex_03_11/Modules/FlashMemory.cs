
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_11.Modules
{
    public class FlashMemory : ISUB
    {
        public static void SendData()
        {
            Console.WriteLine("フラッシュメモリに記録してあるデータをPCに送りました");
        }

        public static void ReciveData()
        {
            Console.WriteLine("PCのデータをフラッシュメモリに記録しました");
        }
    }
}