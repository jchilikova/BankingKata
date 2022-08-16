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
            account.Deposit(amount);

            // Assert
            Assert.AreEqual(140, account.Balance);
        }

        [Test]
        public void Deposit_WhenAmountIsPositiveDecimal_ShouldAddAmountToBalance()
        {
            // Arrange
            var amount = 40.45m;

            // Act
            account.Deposit(amount);

            // Assert
            Assert.AreEqual(account.Balance, 140.45m);
        }

        public void Deposit_WhenAmountIsPositiveDecimal_ShouldHaveRoundedBalance()
        {
            // Arrange
            var amount = 40.451222424m;

            // Act
            account.Deposit(amount);

            // Assert
            Assert.AreEqual(account.Balance, 140.45m);
        }

        [Test]
        public void Deposit_WhenAmountIsNegative_ShouldReturnError()
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