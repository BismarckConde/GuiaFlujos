namespace BankLibrary
{
    public class Record
    {
        public int Account { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        
        public Record() : this(0,string.Empty,string.Empty, 0M)  { }

        public Record (int account, string firtsName, string lastName, decimal balance)
        {
            Account = account;
            FirtsName = firtsName;
            LastName = lastName;
            Balance = balance;
        }
    }
}