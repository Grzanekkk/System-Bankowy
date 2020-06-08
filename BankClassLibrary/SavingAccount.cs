using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{    

    public class SavingAccount : Account
    {

        #region Konstruktory


        public SavingAccount() : base()                // Defultowy konstruktor klasy account jast wywoływany w momencie wywoływanie defultowego konstruktora klas które z niego dziedziczą
        {
            // Dodatkowe przypisywania
            Commission = 0.003m;
        }

        public SavingAccount(int aAccountID, string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress) :
            base(aAccountID, aCustomerName, aDateOfBirth, aPhoneNumber, aAdress)
        {
            Commission = 0.003m;
        }


        #endregion Konstruktory

        #region Metody

        public override void DepositMoney(decimal aAmount)
        { 
            base.DepositMoney(aAmount);                  // Return the base method`s result 
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
