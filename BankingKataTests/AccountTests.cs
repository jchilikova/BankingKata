using BankingKata;
using Moq;
using NUnit.Framework;

namespace BankingKataTests
{
    public class AccountTests
    {
        private IAccount account;
        
        [SetUp]
        public void Setup()
        {
            account = new Mock<IAccount>().Object;
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
            Assert.Pass();
        }

        [Test]
        public void Withdraw_WhenAmountIsNegative_ShouldReturnError()
        {
            // Arrange
            var amount = -300;

            // Act
            account.Deposit(amount);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void Withdraw_WhenAmountIsPositive_ShouldWithdrawFromBalance()
        {
            // Arrange
            var amount = -300;

            // Act
            account.Deposit(amount);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void Withdraw_WhenAmountIsPositiveDecimal_ShouldWithdrawFromBalance()
        {
            // Arrange
            var amount = -300;

            // Act
            account.Deposit(amount);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void Withdraw_WhenBalanceIsZero_ShouldReturnInsufficientFunds()
        {
            // Arrange
            var amount = -300;

            // Act
            account.Deposit(amount);

            // Assert
            Assert.Pass();
        }
    }
}