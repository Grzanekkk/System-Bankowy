using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public class AccountController
    {
        private Account model;

        public AccountController(Account aAccount)
        {
            model = aAccount;
        }

        // A method to display balance
        public void DisplayBalance()
        {
            // Display balance in console.
            Console.WriteLine($"Na twoim koncie znajduje się: {model.CurrentBalance}zł");
        }
    }
}
