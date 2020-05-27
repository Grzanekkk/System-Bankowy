using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public class TransactionController
    {
        private Transaction model;

        public TransactionController(Transaction aTransaction)
        {
            model = aTransaction;
        }

        public void DisplayTransactioninfo()
        {
            Console.WriteLine($"You {model.TransactionTypeString} {model.MoneyAmount}$ in {model.Location}. Date: {model.TransactionDateString}.");
        }
    }
}
