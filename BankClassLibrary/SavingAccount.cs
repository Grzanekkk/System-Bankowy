using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{    

    public class SavingAccount : Account
    {
        const decimal MAX_WITHDRAW = 500;


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

        public override bool DepositMoney(decimal aAmount)
        { 
            return base.DepositMoney(aAmount);                  // Return the base method`s result 
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
