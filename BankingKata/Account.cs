namespace BankingKata
{
    public class Account : IAccount
    {
        public BankStatement Statement { get; set; }

        public void Deposit(int amount)
        {
            throw new System.NotImplementedException();
        }

        public void Withdraw(int amount)
        {
            throw new System.NotImplementedException();
        }

        public BankStatement GetStatement()
        {
            throw new System.NotImplementedException();
        }        
    }
}
