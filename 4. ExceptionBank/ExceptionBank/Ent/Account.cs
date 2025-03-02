namespace ExceptionBank.Ent
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

        public double Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
                throw new AppException("The amount exceeds withdraw limit");

            if (amount > Balance)
                throw new AppException("Not enough balance");

            Balance -= amount;
            return Balance;
        }
    }
}
