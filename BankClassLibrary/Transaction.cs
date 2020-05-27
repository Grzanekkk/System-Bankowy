using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Transaction                     
    {

        #region Zmienne i Właśniwości

        decimal _MoneyAmount;
        DateTime _DateOfTransaction;
        string _Location;

        TypeOfTransaction TypeOfTransaction;       // Emun mogący mieć wartość deposit / withdraw   

        public decimal MoneyAmount
        {
            get
            {
                return _MoneyAmount;
            }
            set
            {
                if (value != 0)
                    _MoneyAmount = value;
                else
                    Console.WriteLine("Jakiś błąd");
            }
        }
        public string Summary                      // Podsumowanie informacje o transakcji
        {
            get
            {
                return ($"{TransactionTypeString} {MoneyAmount} {TransactionDateString}");
            }
        }
        public string TransactionTypeString
        {
            get
            {
                return (TypeOfTransaction == TypeOfTransaction.DEPOSIT ? "Deposit" : "Withdraw");
            }
        }
        public string TransactionDateString
        {
            get
            {
                return _DateOfTransaction.ToString("dd/MM/yyyy hh:mm:dd");
            }
        }
        public DateTime TransactionDate
        {
            get
            {
                return _DateOfTransaction;
            }
        }
        public string Location
        {
            get
            {
                return _Location;
            }
        }


        #endregion Zmienne i Właśniwości

        #region Konstruktory


        // Regular
        public Transaction(TypeOfTransaction aTypeOfTransaction, decimal aAmmountOfTransaction)
        {
            TypeOfTransaction = aTypeOfTransaction;
            _MoneyAmount = aAmmountOfTransaction;
            _DateOfTransaction = DateTime.Now;
            _Location = "EARTH";
        }

        // Default
        public Transaction()
        {
            TypeOfTransaction = 0;
            _MoneyAmount = 0;
            _DateOfTransaction = new DateTime(0000, 00, 00);
            _Location = "UNKNOWN";
        }

        // Copy 
        public Transaction(Transaction copyTransaction)
        {
            TypeOfTransaction = copyTransaction.TypeOfTransaction;
            _MoneyAmount = copyTransaction._MoneyAmount;
            _DateOfTransaction = copyTransaction._DateOfTransaction;
            _Location = copyTransaction._Location;
        }


        #endregion Konstruktory

        #region Metody


        #endregion Metody
    }

    public enum TypeOfTransaction                 // Enum = taka stala tablica ale nie do konca
    {
        DEPOSIT,
        WITHDRAW
    }
}
