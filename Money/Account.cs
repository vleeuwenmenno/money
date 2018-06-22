using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Account
    {
        public decimal balance { get; set; }

        public string accountName { get; set; }
        public string accountNumber { get; set; }
        public string cardType { get; set; }

        public char currencyChar { get; set; }
        public List<Transaction> transactions { get; set; }

        public Account()
        {
            currencyChar = '€';
        }

        public Account(string accountName, string accountNumber)
        {
            currencyChar = '€';
            this.accountName = accountName;
            this.accountNumber = accountNumber;
        }
    }
}
