using System;
using System.Collections.Generic;

namespace BankClassLibrary
{
    public class Account                     // Informacje personalne klienta
    {
        #region Zmienne i właściwości

        int AccountNumber;                           // Unique Account ID

        private const string EMPTY_ADDRESS = "UNKNOWN";
        private const string EMPTY_PHONE = "UNKNOWN";

        Customer AccountCustomer;


        public string CustomerPhoneNumber
        {
            get
            {
                return AccountCustomer.PhoneNumber;
            }

            set
            {
                if (String.IsNullOrEmpty(value))                            // TODO musi być 9 liczby                 
                    AccountCustomer.PhoneNumber = EMPTY_PHONE;                
                else                
                    AccountCustomer.PhoneNumber = value;                
            }
        }

        public string CustomerAddress
        {
            get
            {
                return AccountCustomer.Address;
            }

            set
            {
                if (String.IsNullOrEmpty(value))                
                    AccountCustomer.Address = EMPTY_ADDRESS;               
                else                
                    AccountCustomer.Address = value;                
            }
        }

        public string CustomerName
        {
            get
            {
                return AccountCustomer.CustomerName;
            }
        }

        decimal CurrentBalance;                      // Ammount of money on account
        public decimal Balance
        {
            get
            {
                return CurrentBalance;
            }
        }

        public static decimal KursWymiany = 1.1m;
        public decimal BalanceInForeignCurrency
        {
            get
            {
                return CurrentBalance * KursWymiany;
            }
        }

        List<Transaction> ListOfTransactions;        // Lista wszystkich transakcji na koncie

        public IList<Transaction> TransactionList
        {
            get
            {
                return ListOfTransactions;
            }
        }
        public Transaction LastTransaction
        {
            get
            {
                if (ListOfTransactions.Count == 0)                
                    return null;               
                else                 
                    return ListOfTransactions[ListOfTransactions.Count - 1];              
            }
        }

        #endregion

        #region Konstruktory

        // Regular Konstruktor
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress)          
        {
            AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhoneNumber, aAdress);

            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<Transaction>();
        }

        // Default Konstruktor
        public Account()                        
        {
            AccountCustomer = new Customer("Admin", new DateTime(2000, 1, 1), null, null);

            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<Transaction>();
        }

        // Copy Constructor
        public Account(Account aAcconutToCopy)
        {
            AccountNumber = aAcconutToCopy.AccountNumber;
            CurrentBalance = aAcconutToCopy.CurrentBalance;

            ListOfTransactions = new List<Transaction>();

            for (int i = 0; i < aAcconutToCopy.ListOfTransactions.Capacity; i++)
            {
                // ListOfTransactions[i] = aAcconutToCopy.ListOfTransactions[i];    To też powinno działać.
                 ListOfTransactions.Add(aAcconutToCopy.ListOfTransactions[i]);
            }

            // Skrót
            // ListOfTransactions = new List<Transaction>(aAcconutToCopy.ListOfTransactions);

            // Copy customer
            AccountCustomer = new Customer(aAcconutToCopy.AccountCustomer);
        }

        //Constructor
        public Account(Customer aAccountCustomer)
        {
            AccountCustomer = aAccountCustomer;

            AccountNumber = Guid.NewGuid().GetHashCode();

            CurrentBalance = 0;
            ListOfTransactions = new List<Transaction>();
        }

        #endregion

        #region Metody

        // A method to display balance
        public void DisplayBalance()
        {
            Console.WriteLine($"Na twoim koncie znajduje się: {CurrentBalance}zł");
        }
       
        public bool DepositMoney(decimal aAmount)
        {
            bool isSucces = false;

            CurrentBalance += aAmount;

            // 4. Create deposit transaction and add it to the list

            Transaction myTransaction = new Transaction(TransactionType.DEPOSIT, aAmount);

            ListOfTransactions.Add(myTransaction);

            isSucces = true;

            return isSucces;
        }

        public bool WithdrawMoney(decimal aAmount)
        {
            bool isSucces = false;

            CurrentBalance -= aAmount;

            // 5. Create withdraw transaction and add it to the list

            Transaction myTransaction = new Transaction(TransactionType.WITHDRAW, aAmount);

            ListOfTransactions.Add(myTransaction);

            return isSucces;
        }


        #endregion Metody

        #region Nested types  / Typy zagniezdzone    
        

        public class Transaction                     // Nested = Prywatna klasa/enum etc. sluzonca do urzytku tylko w klasie w ktorej zostaly zagniezdzone
        {
            // 1. Organize class with regions, eliminate public fields using properties
            // 2. Create a method to show the information about the transaction
            // 3. Create a regular, default and copy constructors

            #region Właśniwości


            TransactionType TypeOfTransaction;       // Emun mogący mieć wartość deposit / withdraw     
            DateTime DateOfTransactioin;
            string LocationOfTransaction;
            decimal AmountOfTransaction;

            public decimal TransactionAmount
            {
                get
                {
                    return AmountOfTransaction;
                }
                set
                {
                    if (value != 0)
                        AmountOfTransaction = value;
                    else
                        Console.WriteLine("Jakiś błąd");                 
                }
            }

            public string Summary
            {
                get
                {
                    return ($"{TransactionType} {TransactionAmount} {TransactionDateString}");
                }
            }

            public string TransactionType
            {
                get
                {
                    return (TypeOfTransaction == Account.TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
                }
            }

            public string TransactionDateString
            {
                get
                {
                    return DateOfTransactioin.ToString("dd/MM/yyyy hh:mm:dd");
                }
            }
            public string TransactionLocation
            {
                get
                {
                    return LocationOfTransaction;
                }
            }
            



            #endregion Właściwości

            #region Konstruktory


            // Regular
            public Transaction(TransactionType aTypeOfTransaction, decimal aAmmountOfTransaction)
            {
                TypeOfTransaction = aTypeOfTransaction;
                AmountOfTransaction = aAmmountOfTransaction;     
                DateOfTransactioin = DateTime.Now; 
                LocationOfTransaction = "EARTH";
            }

            // Default
            public Transaction()
            {
                TypeOfTransaction = 0;
                AmountOfTransaction = 0;
                DateOfTransactioin = new DateTime(0000,00,00);
                LocationOfTransaction = "UNKNOWN";
            }

            // Copy 
            public Transaction(Transaction copyTransaction)
            {
                TypeOfTransaction = copyTransaction.TypeOfTransaction;
                AmountOfTransaction = copyTransaction.AmountOfTransaction;
                DateOfTransactioin = copyTransaction.DateOfTransactioin;
                LocationOfTransaction = copyTransaction.LocationOfTransaction;
            }


            #endregion Konstruktory

            #region Metody


            public void ShowTransactioninfo()
            {
                Console.WriteLine($"You {TypeOfTransaction} {AmountOfTransaction}$ in {LocationOfTransaction}. Date: {DateOfTransactioin}.");
            }


            #endregion Metody
        }

        public enum TransactionType                 // Enum = taka stala tablica ale nie do konca
        {
            DEPOSIT,
            WITHDRAW
        }

        #endregion 

    }
}
