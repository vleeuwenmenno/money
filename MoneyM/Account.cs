﻿using System;
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

        public string currencyISO4217 { get; set; }
        public List<Transaction> transactions { get; set; }

        public Transaction GetTransaction(Guid id)
        {
            foreach (Transaction t in transactions)
                if (id == t.id)
                    return t;

            return null;
        }

        public Account()
        {
            currencyISO4217 = "EUR";
            RecalculateBalance();
        }

        public decimal RecalculateBalance(bool save = true)
        {
            decimal balance = initialBalance;
            if (transactions != null)
                foreach (Transaction t in transactions)
                {
                    if (t.status == TransactionStatus.Completed)
                        balance += Tools.ConvertCurrency(t.exchangeSnapshot, t.currencyISO4217, currencyISO4217, t.amount);
                }

            if (save)
                this.currentBalance = balance;

            return balance;
        }

        public Account(string accountName, string accountNumber)
        {
            currencyISO4217 = "EUR";
            this.accountName = accountName;
            this.accountNumber = accountNumber;

            RecalculateBalance();
        }
    }
}
