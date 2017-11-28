using System;

namespace BankAccountKata
{
	public class Account
	{
		public decimal Balance { get; set; }
        public bool CanUseCredit { get; set; }

        private const decimal Credit = 100;

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(decimal withdraw)
        {
            var balanceForWithdraw = CanUseCredit ? Balance + Credit : Balance;
            if (balanceForWithdraw - withdraw >= 0)
                Balance -= withdraw;
        }
    }
}