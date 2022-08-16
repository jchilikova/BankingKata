using System;

namespace BankingKata
{
    public interface IAccount
    {
        decimal Balance { get; set; }

        void Deposit(decimal amount);

        void Withdraw(decimal amount);
    }
}
