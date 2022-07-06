using System;

namespace BankingKata
{
    public interface IAccount
    {
        void Deposit(int amount);

        void Withdraw(int amount);

        BankStatement GetStatement();
    }
}
