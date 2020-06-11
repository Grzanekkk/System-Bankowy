using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankClassLibrary.Account;
using UsefullTools;

namespace DemoForm
{
    public partial class DisplayAccountForm : Form
    {       
        private Account myAccount;

        // Taka specjalna lista do powiązań danych. Potrzebna aby ListBox się updatował po dodanu obiektu do listy
        BindingList<Transaction> dataForListBox;

        // Prywatny defultowy konstruktor aby nie można było tworzyć tego forma bez podania obiektu Account
        private DisplayAccountForm() { }                            

        public DisplayAccountForm(Account aAcount)
        {
            InitializeComponent();

            myAccount = aAcount;

            CustomerNamePanel.TextBoxInput = myAccount.CustomerName;
            CurrentBalancePanel.TextBoxInput = myAccount.CurrentBalance.ToString();

            dataForListBox = new BindingList<Transaction>(myAccount.ListOfTransactions);
            TransactionListBox.DataSource = dataForListBox;
            TransactionListBox.DisplayMember = "Summary";

            TransactionTypeComboBox.Items.Add("Deposit");
            TransactionTypeComboBox.Items.Add("Withdraw");
        }

        private void DisplayAccountForm_Load(object sender, EventArgs e)
        {
            AmountOfTransactionTextBox.KeyPress += UsefullTools.UtilityMethods.OnlyMoneyAllowed;
        }


        #region Eventy

        private void TransactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TransactionListBox.SelectedIndex;

            Transaction selectedTransaction = myAccount.ListOfTransactions[index];
           
            TransactionTypePanel.TextBoxInput = selectedTransaction.TransactionTypeString;
            TransactionAmountPanel.TextBoxInput = selectedTransaction.MoneyAmount.ToString();
            TransactionDatePanel.TextBoxInput = selectedTransaction.TransactionDateString;
            TransactionLocationPanel.TextBoxInput = selectedTransaction.Location;

        }

        private void MakeTransactionButton_Click(object sender, EventArgs e)
        {
            int transactionType = TransactionTypeComboBox.SelectedIndex;        // 0 = Deposit, 1 = Withdraw
            decimal amountOfMoney = Convert.ToDecimal(AmountOfTransactionTextBox.Text);

            if (MakeTransactionButton.BackColor == Color.Red || amountOfMoney == 0)
            {
                return;
            }
            
            if (transactionType == 1)                                           // Withdraw Transaction
            {
                if (amountOfMoney > myAccount.CurrentBalance || myAccount.CurrentBalance == 0)   // PRZY 2x TRUE NIE WYKOUJE SIĘ  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                     
                {
                    MessageBox.Show("You dont have enaugh money for this transaction");         // Za mało kasy na koncie
                    AmountOfTransactionTextBox.Text = myAccount.CurrentBalance.ToString();                                        
                }
                else                                
                {
                    if (!myAccount.WithdrawMoney(amountOfMoney))
                    {
                        MessageBox.Show("Withdraw requets is not valid");
                    }
                    else
                    {
                        myAccount.WithdrawMoney(amountOfMoney);
                    }
                }
            }
            else                                                                // Deposit Transaction
            {
                if (!myAccount.DepositMoney(amountOfMoney))
                {
                    MessageBox.Show("Deposit requets is not valid");                 
                }
                else
                {
                    myAccount.DepositMoney(amountOfMoney);
                }
                             
            }

            CurrentBalancePanel.TextBoxInput = myAccount.CurrentBalance.ToString();
            dataForListBox.ResetBindings();
        }

        private void TransactionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeTransactionButton.BackColor = Color.LightGreen;
        }


        #endregion Eventy

    }
}

