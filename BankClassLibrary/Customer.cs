using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        #region Pola i właściwości

        // Fields / Pola
        string _CustomerName;                    // Imie i nazwisko właściciela konta    
        DateTime _DateOfBirth;
        string _PhoneNumber;                                                          
        string _Address;                                                              

        // Properties / właściwości
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }

            set
            {
                _PhoneNumber = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        #endregion 

        #region Konstruktory


        // Regular constructor    
        public Customer(string aCustomerName, DateTime aDateOfBirht, string aPhoneNumber = null, string aAdress = null)
        {
            _CustomerName = aCustomerName;
            _DateOfBirth = aDateOfBirht;
            _PhoneNumber = aPhoneNumber;
            _Address = aAdress; 
        }

        // Copy constructor
        public Customer(Customer aCustomer)
        {
            _CustomerName = aCustomer.CustomerName;
            _DateOfBirth = aCustomer.DateOfBirth;
            _PhoneNumber = aCustomer.PhoneNumber;
            _Address = aCustomer.Address;
        }

        #endregion Konstrutkory
    }
}
