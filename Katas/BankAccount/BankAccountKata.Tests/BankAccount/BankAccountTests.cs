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
	}
}