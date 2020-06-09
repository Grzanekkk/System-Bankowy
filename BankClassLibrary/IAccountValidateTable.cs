using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    interface IAccountValidateTable
    {
        // Methods for balidating a created account
        bool IsCustomerNameValid(string aCustomerName);
        bool IsBirthDateValid(DateTime aBirthDate);
        bool IsDepositMoneyRequestValid(decimal aMoneyAmount);
        bool IsWithdrawMoneyRequestValid(decimal aMoneyAmount);
    }
}
