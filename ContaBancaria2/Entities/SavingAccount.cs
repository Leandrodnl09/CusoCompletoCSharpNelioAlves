namespace ContaBancaria2.Entities
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {

        }
        public SavingAccount(int number, string holder, double balance, double interestRate) : (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}