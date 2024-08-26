using System;

namespace BankingApp
{
    public class InvestmentAccount : Account
    {
        public double VariableInterestRate { get; set; }

        public InvestmentAccount(int id, double balance, double variableInterestRate) : base(id, balance, 0, 0, 0)
        {
            VariableInterestRate = variableInterestRate;
        }

        public override void CalculateInterest()
        {
            Balance += Balance * VariableInterestRate;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Interest Rate: {VariableInterestRate};";
        }
    }
}