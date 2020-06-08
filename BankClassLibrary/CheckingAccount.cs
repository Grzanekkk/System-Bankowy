using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public sealed class CheckingAccount : Account
    {
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

        public override void DepositMoney(decimal aAmount)
        {
            decimal amountAfterCommission = aAmount - aAmount * Commission;

            base.DepositMoney(amountAfterCommission);                  // Return the base method`s result 
        }

        public override void WithdrawMoney(decimal aAmount)
        {
            decimal amountAfterCommission = aAmount + aAmount * Commission;

            base.WithdrawMoney(amountAfterCommission);
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account Balance: {CurrentBalance}, Commission: {Commission}");
        }


        #endregion Metody
    }
}
