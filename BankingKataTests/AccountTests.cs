using BankingKata;
using Moq;
using NUnit.Framework;

namespace BankingKataTests
{
    public class AccountTests
    {
        private Account account;
        
        [SetUp]
        public void Setup()
        {
            account = new Mock<Account>().Object;
            account.Balance = 100;
        }

        [Test]
        public void Deposit_WhenAmountIsPositive_ShouldAddAmountToBalance()
        {
            // Arrange
            var amount = 40;

            // Act
            var result = account.Deposit(amount);

            // Assert
            Assert.AreEqual(140, result.Balance);
        }

        [Test]
        public void Deposit_WhenAmountIsPositiveDecimal_ShouldAddAmountToBalance()
        {
            // Arrange
            var amount = 40.45m;

            // Act
            var result = account.Deposit(amount);

            // Assert
            Assert.AreEqual(result.Balance, 140.45m);
        }

        public void Deposit_WhenAmountIsPositiveDecimal_ShouldHaveRoundedBalance()
        {
            // Arrange
            var amount = 40.451222424m;

            // Act
            var result = account.Deposit(amount);

            // Assert
            Assert.AreEqual(result.Balance, 140.45m);
        }

        [Test]
        public void Deposit_WhenAmountIsNegative_ShouldReturnError()
        {
            // Arrange
            var amount = -300;

            // Act
            var result = account.Deposit(amount);

            // Assert
            Assert.AreEqual(result.Error, ErrorType.NegativeAmount);
        }

        [Test]
        public void Withdraw_WhenAmountIsNegative_ShouldReturnError()
        {
            // Arrange
            var amount = -3.13m;

            // Act
            var result = account.Withdraw(amount);

            // Assert
            Assert.AreEqual(result.Error, ErrorType.NegativeAmount);
        }

        [Test]
        public void Withdraw_WhenAmountIsPositive_ShouldWithdrawFromBalance()
        {
            // Arrange
            var amount = 20;

            // Act
            var result = account.Withdraw(amount);

            // Assert
            Assert.AreEqual(result.Balance, 80);
        }

        [Test]
        public void Withdraw_WhenAmountIsPositiveDecimal_ShouldWithdrawFromBalance()
        {
            // Arrange
            var amount = 20.20m;

            // Act
            var result = account.Withdraw(amount);

            // Assert
            Assert.AreEqual(result.Balance, 79.80m);
        }

        [Test]
        public void Withdraw_WhenBalanceIsZero_ShouldReturnInsufficientFunds()
        {
            // Arrange
            account.Balance = 0;
            var amount = 100;

            // Act
            var result = account.Withdraw(amount);

            // Assert
            Assert.AreEqual(result.Error, ErrorType.InsufficientFunds);
        }

        [Test]
        public void Withdraw_WhenAmountIsPositiveDecimal_ShouldHaveRoundedBalance()
        {
            // Arrange
            var amount = 7.232556465655m;

            // Act
            var result = account.Withdraw(amount);

            // Assert
            Assert.AreEqual(result.Balance, 92.77M);
        }
    }
}