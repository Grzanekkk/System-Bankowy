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
        }

        public CheckingAccount(int aAccountID, string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress) :
            base(aAccountID, aCustomerName, aDateOfBirth, aPhoneNumber, aAdress)
        {
            
        }

        #region Metody

        public override bool DepositMoney(decimal aAmount)
        {
            return base.DepositMoney(aAmount);                  // Return the base method`s result 
        }

        public override bool WithdrawMoney(decimal aAmount)
        {
            return base.WithdrawMoney(aAmount);
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account Balance: {CurrentBalance}, Commission: {Commission}");
        }

        #endregion Metody
    }
}
