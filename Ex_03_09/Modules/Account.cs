namespace Ex_03_09.Modules
{
    public class Account(string accountNo, string accountName, int balance)
    {
        public string? AccountNo { get; set; } = accountNo;
        public string? AccountName { get; set; } = accountName;
        public int Balance { get; set; } = balance;

        public virtual void Print()
        {
            Console.WriteLine($"口座番号 = {AccountNo}");
            Console.WriteLine($"口座名義 = {AccountName}");
            Console.WriteLine($"残高 = {Balance}");
        }

        public override string ToString()
        {
            return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
        }
    }
}
