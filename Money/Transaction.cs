using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Transaction
    {
        public string desc { get; set; }

        public DateTime dateTime { get; set; }

        public decimal amount { get; set; }

        public Recipient payee { get; set; } // to
        public Recipient account { get; set; } // from

        public TransactionStatus status { get; set; }
    }
}
