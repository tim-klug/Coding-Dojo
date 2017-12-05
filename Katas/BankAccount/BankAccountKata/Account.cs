using System;
using System.Collections.Generic;

namespace BankAccountKata
{
	public class Account : IAccount
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

		public IEnumerable<ITransaction> TransactionHistory()
		{
			return new List<ITransaction>();	
		}
	}

	public class Transaction : ITransaction
	{
		public decimal Amount { get; set; }
		public DateTime TransactionDate { get; set; }
		public IAccount FromAccount { get; set; }
	}
}