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
    }
}