using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        #region Zmienne

        public string CustomerName;                    // The name of account holder
        DateTime DateOfBirth;
        public string PhoneNumber;
        public string Address;

        #endregion Zmienne

        #region Konstruktory

        public Customer(string aCustomerName, DateTime aDateOfBirht, string aPhoneNumber = null, string aAdress = null)
        {
            CustomerName = aCustomerName;
            DateOfBirth = aDateOfBirht;
            PhoneNumber = aPhoneNumber;
            Address = aAdress; 
        }

        // Copy constructor
        public Customer(Customer aCustomer)
        {
            CustomerName = aCustomer.CustomerName;
            DateOfBirth = aCustomer.DateOfBirth;
            PhoneNumber = aCustomer.PhoneNumber;
            Address = aCustomer.Address;
        }

        #endregion Konstrutkory
    }
}
