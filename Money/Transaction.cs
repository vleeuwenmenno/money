using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Transaction
    {
        public decimal amount { get; set; }

        public decimal exchange { get; set; } //USD/CURRENCY

        public string currencyISO4217 { get; set; }

        public Guid id { get; set; }

        public Guid intern { get; set; }

        public string desc { get; set; }

        public string payee { get; set; } // to

        public DateTime dateTime { get; set; }

        public TransactionStatus status { get; set; }

        public TransactionType type { get; set; }
    }
}
