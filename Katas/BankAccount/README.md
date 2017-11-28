# Bank Account

Write a program that simulates a bank account.

## Getting Started

The idea is to make this Dojo in TDD and remote. So everybody is working on their own machine and environment. To give some guidance, all projects are already added. For testing we will use NUnit with FluentAssertions. All necessary packages are already added to the project. run a `dotnet restore` and start coding. Other frameworks are optional and can be used or just try out.

Optional packages are:

- [LightBDD.NUnit3](https://github.com/LightBDD/LightBDD)

## Starting the Dojo

Which kind of development environment is used, shouldn't make any difference. Start the Dojo when everybody is ready. This means every attendee had cloned the repository and opened the IDE of choice.

The one who runs the Dojo should fork the code and create a new branch. Every attendee will clone this repository and work on the same branch. One one persons codes at the time and will run red --> green --> refactor --> commit --> push. Then the next one will make the next step. Some steps will have more than one test. Try making small steps with only small portions of code.

Start the Dojo with the first scenario and do not read the next expectations until you reach them. Like in real life, you do not know what will a project own create next. Write a test that fails (red), write just enough code to make the test pass (green) and the refactor the code until satisfaction.

Do not extend the requirements of your own. Ship what the customer / product owner asked for.

### BDD

The scenarios are designed to be written to fit as behavior driven development. The product owner, who defines the requirements is getting sloppy with his work. Some of his requirements may have to be redefined or extended.

### VS Code

To start automatic testing run `dotnet watch test` in the command line (execute this command in the root of the test project).

### R#

Just kick of a continuous testing session.

### NCrunch

Configure the runner and let's code.

### VS

Run every test with the associated shortcut and check the result.

## Scenarios

There are different scenarios that will form the overall behavior of a bank account.

### Scenario 1

> Our Bank needs accounts, but every new account will start without any deposit.

Given a new bank account, when the bank account is newly created, then the initial amount is zero.

### Scenario 2

> This customer wanted to deposit his money, but our system did not let him - even when he has an account at our bank.

Given a bank account, when depositing a given amount to an account, then this amount is added to accounts balance.

### Scenario 3

> This customer wanted to withdraw some money from his account. But our system did not let him.

Given a bank account, when withdrawing an amount, then the account's balance is reduced by this amount.

### Scenario 4

> This customer wanted to withdraw money, but could exceed his balance easily. We lost a lot of money!

Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.

### Scenario 5

> A customer is in need of more money than he has now. We should allow him and a few other good customers to exceed their current account's balance.

Given a bank account with a possible credit, when withdrawing an amount from this account, that does exceed the balance, then the account's balance is negative.

### Scenario 6

> One of the customers, we allowed to exceed their balance left with a lot of stash! We need to allow these customer only a limited credit!

Given a bank account with a credit limit, when a withdraw exceeds the amount of balance and credit, then the transaction is rejected.

### Scenario 7

> A customer did not know, that his account's balance is already nearby zero. He wanted to know, when and how money has been withdrawn.

Given a bank account with a transaction history, when the account holder asked for the account movements, then all movements are displayed one by one.

### Scenario 8

> Remember the last customer? He could not identify his transactions. We need descriptions at the account movements!

Given a transaction for a bank account, when the user added a description, then this description is displayed with the account movements.

### Scenario 9

> We will offer the customers to store some of their money in instant access saving accounts. No money can be withdrawn from this account, except to the owner's giro account.

Given a bank account, when the account is of type instant access saving account, then money can only be transferred to a giro account of the same user.

### Scenario 11

> Until now, every transaction had be withdrawn first and deposited separately. Hopefully no money had been lost during this process. But our system should combine them and check, if the destination account exists and proceed the booking. 

Given two bank accounts from different users, when an amount is transferred from one account to the other, then the amount from the __from account__ is withdrawn and the amount is added to the __to account__.
