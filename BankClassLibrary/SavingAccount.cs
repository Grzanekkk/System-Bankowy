using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{    

    class SavingAccount : Account
    {

        #region Konstruktory


        public SavingAccount() : base()                // Defultowy konstruktor klasy account jast wywoływany w momencie wywoływanie defultowego konstruktora klas które z niego dziedziczą
        {
            // Dodatkowe przypisywania
        }

        public SavingAccount(int aAccountID, string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress) :
            base(aAccountID, aCustomerName, aDateOfBirth, aPhoneNumber, aAdress)
        {

        }


        #endregion Konstruktory

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
