using System;
using System.Security.Principal;

namespace BankingApp
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public Account[] Accounts { get; set; }

        public Customer(int customerNumber, string name, string contactDetails, Account[] accounts)
        {
            CustomerNumber = customerNumber;
            Name = name;
            ContactDetails = contactDetails;
            Accounts = accounts;
        }
    }
}