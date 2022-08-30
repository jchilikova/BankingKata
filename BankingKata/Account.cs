using System;

namespace BankingKata
{
    public class Account : IAccount
    {
        private const int round = 2;

        public decimal Balance { get; set; }

        public BalanceResult Deposit(decimal amount)
        {
            return new BalanceResult()
            {
                Balance = Math.Round(Balance += amount, round),
                Error = null
            };
        }

        public BalanceResult Withdraw(decimal amount)
        {
            return new BalanceResult()
            {
                Balance = Math.Round(Balance -= amount, round),
                Error = null
            };
        }
    }
}
