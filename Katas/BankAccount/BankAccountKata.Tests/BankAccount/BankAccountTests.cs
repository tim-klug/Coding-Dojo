using FluentAssertions;
using NUnit.Framework;

namespace BankAccountKata.Tests.BankAccount
{
	[TestFixture]
	public class BankAccountTests
	{
		[Test(Description = "Given a new bank account, when the bank account is newly created, then the initial amount is zero.")]
		public void Given_a_new_bank_account_when_the_bank_account_is_newly_created_then_the_initial_amount_is_zero()
		{
			var bankAccount = new Account();

			bankAccount.Balance.Should().Be(0);
		}

        [Test(Description = "Given a bank account, when depositing a given amount to an account, then this amount is added to accounts balance.")]
        public void Given_a_bank_account_when_depositing_a_given_amount_to_an_account_then_this_amount_is_added_to_accounts_balance()
        {
            var bankAccount = new Account();

            bankAccount.Deposit(42.17m);

            bankAccount.Balance.Should().Be(42.17m);
        }

		[Test(Description = "Given a bank account, when withdrawing an amount, then the account's balance is reduced by this amount.")]
		public void Given_a_bank_account_when_withdrawing_an_amount_then_the_accounts_balance_is_reduced_by_this_amount()
		{
			var bankAccount = new Account();

			bankAccount.Withdraw(55.55m);

			bankAccount.Balance.Should().Be(-55.55m);
		}
    }
}