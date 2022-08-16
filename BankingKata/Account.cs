using System;

namespace BankingKata
{
    public class Account : IAccount
    {
        private const int round = 2;

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Math.Round(Balance += amount, round);
        }

        public void Withdraw(decimal amount)
        {
            Math.Round(Balance -= amount, round);
        }
    }
}
