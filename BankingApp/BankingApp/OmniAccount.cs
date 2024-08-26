using System;

namespace BankingApp
{
    public class OmniAccount : Account
    {
        public OmniAccount(int id, double balance, double interestRate, double overdraftLimit) : base(id, balance, interestRate, overdraftLimit, 0) { }

        public override void CalculateInterest()
        {
            if (Balance > 1000)
            {
                Balance += Balance * InterestRate;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Interest Rate: {InterestRate}; Overdraft Limit: {OverdraftLimit};";
        }
    }
}