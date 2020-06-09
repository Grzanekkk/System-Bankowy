using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public sealed class CheckingAccount : Account
    {
        const decimal MIN_DEPOSTI = 150;
        const decimal MAX_WITHDRAW = 5000;

        public CheckingAccount() : base()                // Defultowy konstruktor klasy account jast wywoływany w momencie wywoływanie defultowego konstruktora klas które z niego dziedziczą
        {
            // Dodatkowe przypisywania
            Commission = 0.01m;
        }

        public CheckingAccount(int aAccountID, string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress) :
            base(aAccountID, aCustomerName, aDateOfBirth, aPhoneNumber, aAdress)
        {
            Commission = 0.01m;
        }

        #region Metody

        public override bool DepositMoney(decimal aAmount)
        {
            if (!IsDepositMoneyRequestValid(aAmount))
            {
                return false;
            }

            decimal amountAfterCommission = aAmount - aAmount * Commission;

            return base.DepositMoney(amountAfterCommission);                  // Return the base method`s result 
        }

        public override bool WithdrawMoney(decimal aAmount)
        {
            if (!IsWithdrawMoneyRequestValid(aAmount))
            {
                return false;
            }
            decimal amountAfterCommission = aAmount + aAmount * Commission;

            return base.WithdrawMoney(amountAfterCommission);
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account Balance: {CurrentBalance}, Commission: {Commission}");
        }

        public override bool IsDepositMoneyRequestValid(decimal aMoneyAmount)              
        {
            if (aMoneyAmount < MIN_DEPOSTI)
            {
                return false;
            }
            return true;
        }
        public override bool IsWithdrawMoneyRequestValid(decimal aMoneyAmount)
        {
            if (aMoneyAmount > MAX_WITHDRAW)
            {
                return false;
            }
            return true;
        }


        #endregion Metody
    }
}
