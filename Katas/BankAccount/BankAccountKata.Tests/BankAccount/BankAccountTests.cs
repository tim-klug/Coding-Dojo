using FluentAssertions;
using NUnit.Framework;

namespace BankAccountKata.Tests.BankAccount
{
	[TestFixture]
	public class BankAccountTests
	{
        private Account _account;

        [SetUp]
		public void Setup()
		{
			_account = new Account();
		}

		[TearDown]
		public void Cleanup()
		{
			_account = null;
		}

		[Test(Description = "Given a new bank account, when the bank account is newly created, then the initial amount is zero.")]
		public void Given_a_new_bank_account_when_the_bank_account_is_newly_created_then_the_initial_amount_is_zero()
		{
			_account.Balance.Should().Be(0);
		}

        [Test(Description = "Given a bank account, when depositing a given amount to an account, then this amount is added to accounts balance.")]
        public void Given_a_bank_account_when_depositing_a_given_amount_to_an_account_then_this_amount_is_added_to_accounts_balance()
        {
            _account.Deposit(42.17m);

            _account.Balance.Should().Be(42.17m);
        }

		[Test(Description = "Given a bank account, when withdrawing an amount, then the account's balance is reduced by this amount.")]
		public void Given_a_bank_account_when_withdrawing_an_amount_then_the_accounts_balance_is_reduced_by_this_amount()
		{
			_account.Deposit(55.55m);
			_account.Withdraw(55.55m);

			_account.Balance.Should().Be(0);
		}

		[TestCase(30, 40, 30, Description="Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.")]
		[TestCase(30, 20, 10, Description="Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.")]
		[TestCase(20, 40, 20, Description="Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.")]
		[TestCase(50, 40, 10, Description="Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.")]
		[TestCase(0, 0, 0, Description="Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.")]
		public void Given_a_bank_account_when_withdrawing_an_amount_that_exceeds_the_accounts_balance_then_the_withdraw_is_rejected(decimal deposit, decimal withdraw, decimal result)
		{
			_account.Deposit(deposit);
			_account.Withdraw(withdraw);

			_account.Balance.Should().Be(result);
        }

        [Test(Description = "Given a bank account with a possible credit, when withdrawing an amount from this account, that does exceed the balance, then the account's balance is negative.")]
        public void Given_a_bank_account_with_a_possible_credit_when_withdrawing_an_amount_from_this_account_that_does_exceed_the_balance_then_the_account_s_balance_is_negative()
        {
            _account.Limit(100);
            _account.Deposit(50m);
            _account.Withdraw(70m);

            _account.Balance.Should().Be(-20);
        }

        [TestCase(0, 10, 20, 10, Description = "Given a bank account with a credit limit, when a withdraw exceeds the amount of balance and credit, then the transaction is rejected.")]
        [TestCase(100, 10, 20, -10, Description = "Given a bank account with a credit limit, when a withdraw exceeds the amount of balance and credit, then the transaction is rejected.")]
        [TestCase(50, 200, 20, 180, Description = "Given a bank account with a credit limit, when a withdraw exceeds the amount of balance and credit, then the transaction is rejected.")]
        [TestCase(230, 0, 229, -229, Description = "Given a bank account with a credit limit, when a withdraw exceeds the amount of balance and credit, then the transaction is rejected.")]
        public void Given_a_bank_account_with_a_credit_limit_when_a_withdraw_exceeds_the_amount_of_balance_and_credit_then_the_transaction_is_rejected(decimal credit, decimal deposit, decimal withdraw, decimal expected)
        {
            _account.Limit(credit);
            _account.Deposit(deposit);
            _account.Withdraw(withdraw);

            _account.Balance.Should().Be(expected);
        }
    }
}