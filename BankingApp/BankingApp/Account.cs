using System;

namespace BankingApp
{
    public abstract class Account
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public double OverdraftLimit { get; set; }
        public double FeeForFailedWithdrawals { get; set; }

        public Account(int id, double balance, double interestRate, double overdraftLimit, double feeForFailedWithdrawals)
        {
            Id = id;
            Balance = balance;
            InterestRate = interestRate;
            OverdraftLimit = overdraftLimit;
            FeeForFailedWithdrawals = feeForFailedWithdrawals;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > Balance + OverdraftLimit)
            {
                Balance -= FeeForFailedWithdrawals;
                throw new System.InvalidOperationException("Insufficient funds");
            }
            Balance -= amount;
        }

        public virtual void CalculateInterest()
        {
            // Default implementation, can be overridden by derived classes
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Id}; Balance: {Balance};";
        }
    }
}