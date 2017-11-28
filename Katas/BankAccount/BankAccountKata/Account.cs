using System;

namespace BankAccountKata
{
	public class Account
	{
		public decimal Balance { get; set; }
        public bool CanUseCredit { get; set; }
        public decimal CreditLimit { get; private set; } // not to change from outside ;)

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(decimal withdraw)
        {
            var balanceForWithdraw = CanUseCredit ? Balance + CreditLimit : Balance;
            if (balanceForWithdraw - withdraw >= 0)
                Balance -= withdraw;
        }

        public void Limit(decimal credit)
        {
            CreditLimit = credit;
            CanUseCredit = true;
        }
    }
}