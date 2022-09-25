using System;

namespace BankingKata
{
    public class Account : IAccount
    {
        private const int round = 2;

        public decimal Balance { get; set; }

        public BalanceResult Deposit(decimal amount)
        {
            if (CheckIfAmountIsNegative(amount))
            {
                return GetNegativeAmountError();
            }

            return new BalanceResult()
            {
                Balance = Math.Round(Balance += amount, round),
                Error = null
            };
        }

        public BalanceResult Withdraw(decimal amount)
        {
            var currentBalance = Balance;

            if (CheckIfAmountIsNegative(amount))
            {
                return GetNegativeAmountError();
            }
            
            var result = Math.Round(currentBalance -= amount, round);

            if (CheckIfAmountIsNegative(result))
            {
                return new BalanceResult()
                {
                    Balance = Balance,
                    Error = ErrorType.InsufficientFunds
                };
            }

            this.Balance = result;

            return new BalanceResult()
            {
                Balance = result,
                Error = null
            };
        }

        private bool CheckIfAmountIsNegative(decimal amount)
        {
            return amount < 0;
        }

        private BalanceResult GetNegativeAmountError()
        {
            return new BalanceResult()
            {
                Balance = Balance,
                Error = ErrorType.NegativeAmount
            };
        }
    }
}
