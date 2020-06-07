using System;
using System.Collections.Generic;

namespace BankClassLibrary
{
    public class Account : AccountBase                     // Informacje personalne klienta
    {
        #region Zmienne i właściwości


        private const string EMPTY_ADDRESS = "UNKNOWN";
        private const string EMPTY_PHONE = "UNKNOWN";

        private Customer _AccountCustomer;

        private decimal _CurrentBalance;                      // Ammount of money on account

        private int _AccountID;                               // Unique Account ID

        private static decimal _KursWymiany = 1.1m;

        private List<Transaction> _ListOfTransactions;        // Lista wszystkich transakcji na koncie

        private double _Commission;



        public override int AccountID
        {
            get
            {
                return _AccountID;
            }
        }

        public string CustomerPhoneNumber
        {
            get
            {
                return _AccountCustomer.PhoneNumber;
            }

            set
            {
                if (String.IsNullOrEmpty(value))                            // TODO musi być 9 liczby                 
                    _AccountCustomer.PhoneNumber = EMPTY_PHONE;                
                else                
                    _AccountCustomer.PhoneNumber = value;                
            }
        }

        public string CustomerAddress
        {
            get
            {
                return _AccountCustomer.Address;
            }

            set
            {
                if (String.IsNullOrEmpty(value))                
                    _AccountCustomer.Address = EMPTY_ADDRESS;               
                else                
                    _AccountCustomer.Address = value;                
            }
        }

        public string BirthDateString
        {
            get
            {
                return _AccountCustomer.DateOfBirth.ToString("dd/MM/yyyy hh:mm:dd");
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _AccountCustomer.DateOfBirth;
            }
        }

        public override string CustomerName
        {
            get
            {
                return _AccountCustomer.CustomerName;
            }
            set
            {
                _AccountCustomer.CustomerName = value;
            }
        }

        public override decimal CurrentBalance
        {
            get
            {
                return _CurrentBalance;
            }
        }

        public override double Commission 
        { 
            get 
            {
                return _Commission;
            }
            set
            {
                _Commission = value;
            }
        }

        public decimal CurrentBalanceInForeignCurrency
        {
            get
            {
                return _CurrentBalance * _KursWymiany;
            }
        }

        public List<Transaction> ListOfTransactions
        {
            get
            {
                return _ListOfTransactions;
            }
        }

        public Transaction LastTransaction
        {
            get
            {
                if (_ListOfTransactions.Count == 0)                
                    return null;               
                else                 
                    return _ListOfTransactions[_ListOfTransactions.Count - 1];              
            }
        }


        #endregion Zmienne i właściwości


        #region Konstruktory


        // Regular Konstruktor
        public Account(string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress)          
        {
            _AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhoneNumber, aAdress);

            _AccountID = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }

        // Default Konstruktor
        public Account()                        
        {
            _AccountCustomer = new Customer("Admin", new DateTime(2000, 1, 1), null, null);

            _AccountID = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }

        // Copy Constructor
        public Account(Account aAcconutToCopy)
        {
            _AccountID = aAcconutToCopy.AccountID;
            _CurrentBalance = aAcconutToCopy._CurrentBalance;

            _ListOfTransactions = new List<Transaction>();

            for (int i = 0; i < aAcconutToCopy._ListOfTransactions.Capacity; i++)
            {
                 _ListOfTransactions.Add(aAcconutToCopy._ListOfTransactions[i]);
            }

            _AccountCustomer = new Customer(aAcconutToCopy._AccountCustomer);
        }

        // Constructor
        public Account(Customer aAccountCustomer)
        {
            _AccountCustomer = aAccountCustomer;

            _AccountID = Guid.NewGuid().GetHashCode();

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }

        // Read From File Constructor
        public Account(int aAccountID, string aCustomerName, DateTime aDateOfBirth, string aPhoneNumber, string aAdress)
        {
            _AccountCustomer = new Customer(aCustomerName, aDateOfBirth, aPhoneNumber, aAdress);

            _AccountID = aAccountID;

            _CurrentBalance = 0;
            _ListOfTransactions = new List<Transaction>();
        }


        #endregion Konstruktory


        #region Metody


        public override bool DepositMoney(decimal aAmount)
        {
            bool isSucces = false;

            _CurrentBalance += aAmount;

            Transaction myTransaction = new Transaction(TypeOfTransaction.DEPOSIT, aAmount);

            _ListOfTransactions.Add(myTransaction);

            isSucces = true;

            return isSucces;
        }

        public override bool WithdrawMoney(decimal aAmount)
        {
            bool isSucces = false;

            _CurrentBalance -= aAmount;

            // 5. Create withdraw transaction and add it to the list

            Transaction myTransaction = new Transaction(TypeOfTransaction.WITHDRAW, aAmount);

            _ListOfTransactions.Add(myTransaction);

            isSucces = true;

            return isSucces;
        }

        public void AddTransaction(Transaction newTransaction)
        {
            _ListOfTransactions.Add(newTransaction);

            switch(newTransaction.TransactionTypeString)
            {
                case "Deposit":
                    _CurrentBalance += newTransaction.MoneyAmount;
                    break;
                case "Withdraw":
                    _CurrentBalance -= newTransaction.MoneyAmount;
                    break;
            }
        }

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account ID: {_AccountID}. Current balance {_CurrentBalance}. Regular account type");
        }



        #endregion Metody

    }
}
