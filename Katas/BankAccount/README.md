# Bank Account

Write a program that simulates a bank account.

## Getting Started

The idea is to make this Dojo in TDD and remote. So everybody is working on their own machine and environment. To give some guidance, all projects are already added. For testing we will use NUnit with FluentAssertions. All necessary packages are already added to the project. run a `dotnet restore` and start coding. Other frameworks are optional and can be used or just try out.

Optional packages are:

- [LightBDD.NUnit3](https://github.com/LightBDD/LightBDD)

## Starting the Dojo

Which kind of development environment is used, shouldn't make any difference. Start the Dojo when everybody is ready. This means every attendee had cloned the repository and opened the IDE of choice.

The one who runs the Dojo should fork the code and create a new branch. Every attendee will clone this repository and work on the same branch. One one persons codes at the time and will run red --> green --> refactor --> commit --> push. Then the next one will make the next step. Some steps will have more than one test. Try making small steps with only small portions of code.

Start the Dojo with the first scenario and do not read the next expectations until you reach them. Like in real life, you do not know what will a project own create next. Write a test that fails (red), write just enough code to make the test pass (green) and the refactor the code.

### VS Code

To start automatic testing run `dotnet watch test` in the command line (execute this command in the root of the test project).

### R#

Just kick of a continuous testing session.

### NCrunch

Configure the runner and let's code.

### VS

Run every test with the associated shortcut and check the result.

## Scenarios

There are different scenarios that will form the overall behavior of the bank account.

### Scenario 1

Given a new bank account, when the bank account is newly created, then the initial amount is zero.

### Scenario 2

Given a bank account, when deposing a given amount to an account, then this amount is added to accounts balance.

### Scenario 3

Given a bank account, when withdrawing an amount, then the accounts balance is reduced by this amount.

### Scenario 4

Given a bank account, when withdrawing an amount that exceeds the accounts balance, then the withdraw is rejected.

### Scenario 5

Given a bank account with a credit limit, when withdrawing an amount from this account that does not exceed balance and credit but is greater than the balance, then the accounts balance is negative.

### Scenario 6

Given a bank account with a credit limit, when a withdraw exceeds the amount of balance and credit, then the transaction is rejected.

### Scenario 7

Given a bank account with a transaction history, when the account holder asked for the account movements, then all movements are printed out to the console one by one.

### Scenario 8

Given a transaction for a bank account, when the user added as description, then this description is printed out with the account movements.

### Scenario 9

Given a bank account, when the account is of type instant access saving account, then money can only be transfer to a giro account if the same user.

### Scenario 10

Given two bank accounts from different users, when money is transfer from one account to the other, than the from account is reduced by the amount and the to account is increased by the amount.
