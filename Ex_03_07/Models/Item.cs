using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_07.Models
{
    public class Item
    {
        public int itemNo { get; set; }
        public string itemName { get; set; } = string.Empty;
        public int price { get; set; }

        public void Print()
        {
            Console.WriteLine("結果");
            Console.WriteLine($"商品番号 = {itemNo}");
            Console.WriteLine($"商品名 = {itemName}");
            Console.WriteLine($"単価 = {price}");
        }
    }
}

