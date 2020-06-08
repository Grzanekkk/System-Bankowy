using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public abstract class AccountBase
    {
        public abstract int AccountID { get; }
        public abstract string CustomerName { get; set; }
        public abstract decimal CurrentBalance { get; }
        public abstract decimal Commission { get; set; }         // Prowizja dla banku
        public abstract void DepositMoney(decimal aAmount);
        public abstract void WithdrawMoney(decimal aAmount);
        protected abstract void AddTransaction(Transaction aNewTransaction);
    }
}
