using System;

namespace BankAccountKata
{
	public interface ITransaction
	{
		decimal Amount { get; set; }
		IAccount FromAccount { get; set; }
		DateTime TransactionDate { get; set; }
	}
}