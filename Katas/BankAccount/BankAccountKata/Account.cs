using System;

namespace BankAccountKata
{
	public class Account
	{
		public decimal Balance { get; set; }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(decimal withdraw)
        {
            if (Balance - withdraw >= 0)
                Balance -= withdraw;
        }
    }
}