using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Account
    {
        public decimal initialBalance { get; set; }

        public decimal currentBalance { get; set; }

        public string accountName { get; set; }
        public string accountNumber { get; set; }
        public string type { get; set; }

        public char currencyChar { get; set; }
        public List<Transaction> transactions { get; set; }

        public Account()
        {
            currencyChar = '€';
            RecalculateBalance();
        }

        public decimal RecalculateBalance(bool save = true)
        {
            decimal balance = initialBalance;
            if (transactions != null)
                foreach (Transaction t in transactions)
                {
                    balance += t.amount;
                }

            if (save)
                this.currentBalance = balance;

            return balance;
        }

        public Account(string accountName, string accountNumber)
        {
            currencyChar = '€';
            this.accountName = accountName;
            this.accountNumber = accountNumber;

            RecalculateBalance();
        }
    }
}
