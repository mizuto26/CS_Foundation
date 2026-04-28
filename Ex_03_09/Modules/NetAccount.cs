using System;

namespace Ex_03_09.Modules
{
    public class NetAccount(string accountNo, string accountName, int balance, int point)
        : Account(accountNo, accountName, balance)
    {
        public int Point { get; set; } = point;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"ポイント = {Point}");
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"NetAccount[{base.ToString()},Point={Point}]";
        }
    }
}
