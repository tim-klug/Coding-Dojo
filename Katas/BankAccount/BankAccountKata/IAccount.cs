using System.Collections.Generic;

namespace BankAccountKata
{
	public interface IAccount
	{
		decimal Balance { get; set; }
		bool CanUseCredit { get; set; }
		decimal CreditLimit { get; }

		void Deposit(decimal deposit);
		void Limit(decimal credit);
		IEnumerable<ITransaction> TransactionHistory();
		void Withdraw(decimal withdraw);
	}
}