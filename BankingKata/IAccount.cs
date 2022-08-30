using System;

namespace BankingKata
{
    public interface IAccount
    {
        decimal Balance { get; set; }

        BalanceResult Deposit(decimal amount);

        BalanceResult Withdraw(decimal amount);
    }
}
