using System;

namespace BankingApp
{
    public class EverydayAccount : Account
    {
        public EverydayAccount(int id, double balance) : base(id, balance, 0, 0, 0) { }
    }
}