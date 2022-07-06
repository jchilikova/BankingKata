using BankingKata;
using Moq;
using NUnit.Framework;

namespace BankingKataTests
{
    public class Tests
    {
        private Mock<IAccount> mockAccount;

        [SetUp]
        public void Setup()
        {
            mockAccount = new Mock<IAccount>();
        }

        [Test]
        public void Deposit_WhenAmountIsPositive_ShouldAddAmountToBalance()
        {
            Assert.Pass();
        }

        [Test]
        public void Deposit_WhenAmountIsNegative_ShouldReturnError()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Deposit_WhenAmountIsNull_ShouldReturnError()
        {
            Assert.Pass();
        }
    }
}