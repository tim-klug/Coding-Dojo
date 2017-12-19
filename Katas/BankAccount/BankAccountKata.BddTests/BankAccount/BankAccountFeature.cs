using FluentAssertions;
using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.NUnit3;
using NUnit.Framework;

namespace BankAccountKata.BddTests.BankAccount
{
	[TestFixture]
	[FeatureDescription(@"In order to get a new Bank Account
As a user
I want to create a new Bank Account")]
	[Label("Story-1")]
	public partial class BankAccountFeature
	{
        [Scenario]
		[Label("Ticket-1")]
		[ScenarioCategory("Bank Account Management")]
		public void Create_new_Bank_Account()
		{
			Runner.RunScenario(
				Given_a_new_bank_account,
				When_the_account_is_newly_created,
				Then_the_initial_amount_is_zero
			);
		}
	}

	public partial class BankAccountFeature : FeatureFixture {
        private Account _Account;

        private void Given_a_new_bank_account()
		{
			_Account = new Account();
		}

		private void When_the_account_is_newly_created()
		{
			// nothing ti do here
		}

		private void Then_the_initial_amount_is_zero()
		{
			_Account.Balance.Should().Be(0);
		}
	}
}