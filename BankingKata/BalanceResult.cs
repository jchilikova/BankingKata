namespace BankingKata
{
    public class BalanceResult
    {
        public decimal Balance { get; internal set; }

        public ErrorType? Error { get; internal set; }
    }
}