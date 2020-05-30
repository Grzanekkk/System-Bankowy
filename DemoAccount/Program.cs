using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankClassLibrary;


                                                                        //OLD STARTUP PROJECT
namespace DemoAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopConditio = true;

            // Create an Account
            Account myAccount = CreateAnAccount();



            while (loopConditio)
            {
                // Deposit Money
                DepositMoney(myAccount, 1000);

                // Display last transaction
               // myAccount.LastTransaction.DisplayTransactioninfo();

                // Withdraw Money
                WithdrawMoney(myAccount, 500);

                // Display Balance
                DisplyBalance(myAccount);

                UtilityMethods.PressAnyKeyToContinue();
            }

            UtilityMethods.PressAnyKeyToContinue();
        }

        private static void DepositMoney(Account aAccount, decimal aMoney)
        {
            aAccount.DepositMoney(aMoney);
        }

        private static void WithdrawMoney(Account aAccount, decimal aMoney)
        {
            aAccount.WithdrawMoney(aMoney);
        }

        private static void DisplyBalance(Account aAccount)
        {
           // aAccount.DisplayBalance();
        }

        private static Account CreateAnAccount()
        {
            string customerName = UtilityMethods.ReadTextInput("Prosze podać swoje imię:");


            Console.WriteLine("Prosze podać swoją date urodzenia");

            int day = UtilityMethods.ReadNumericInput("Dzień:");

            int month = UtilityMethods.ReadNumericInput("Miesiąc:");

            int year = UtilityMethods.ReadNumericInput("Rok:");


            string phoneNumer = UtilityMethods.ReadTextInput("Prosze podać swój numer telefonu:");

            string address = "";
            UtilityMethods.ReadTextInput("Prosze podać swój adres:", ref address);


            Account newAccount = new Account(new Customer(customerName, new DateTime(year, month, day), phoneNumer, address));

            return newAccount;
        }
    }
}
