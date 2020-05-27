﻿using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class CreateAccountForm : Form
    {
        #region Właściwości + Konstruktor

        private string PhoneTextInput
        {
            get
            {
                if (mtxtPhoneNumber.Enabled)
                {
                    return mtxtPhoneNumber.Text; 
                }
                else
                {
                    return null;
                }
            }
        }

        private string AddressTextInput
        {
            get
            {
                if (rtxtAddress.Enabled)
                {
                    return rtxtAddress.Text;
                }
                else
                {
                    return null;
                }
            }
        }


        public CreateAccountForm()
        {
            InitializeComponent();
        }

        #endregion Właściwości + Konstruktor

        #region Eventy

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Create button has been clicked");

            string customerName = txtCustomerName.Text;
            DateTime birthDate = BirthDatePicker.Value;

            if (!ValidateCustomerName(customerName))
            {
                MessageBox.Show("Customer Name is invalid");
                return;
            }
            else if (ValidateCustomerBirthDate(birthDate))
            {
                MessageBox.Show("You have to at least 18 years old to create an account in our bank");
                return;
            }

            string phoneNumber = PhoneTextInput;
            string address = AddressTextInput;

            Account newAccount = new Account(customerName, birthDate, phoneNumber, address);

            newAccount.DepositMoney(1000);
            newAccount.WithdrawMoney(500);

            DisplayAccountForm displayAccount = new DisplayAccountForm(newAccount);

            this.Hide();
            displayAccount.ShowDialog();
            this.Show();

            // MessageBox.Show($"Account of customer {customerName} has been created.");

        }

        #endregion Eventy

        #region Metody

        private void cbPhone_CheckedChanged(object sender, EventArgs e)
        {
            mtxtPhoneNumber.Enabled = cbPhone.Checked;
        }

        private void cbAddress_CheckedChanged(object sender, EventArgs e)
        {
            rtxtAddress.Enabled = cbAddress.Checked;
        }

        private bool ValidateCustomerName(string aCustomerName)
        {
            if (!string.IsNullOrEmpty(aCustomerName) && aCustomerName.Length > 5 && aCustomerName.Length < 30)           
                return true;           
            else           
                return false;           
        }

        private bool ValidateCustomerBirthDate(DateTime aDateOfBirth)
        {
            if (DateTime.Compare(aDateOfBirth, new DateTime(DateTime.Now.Year - 18, 12, 31)) == 1)
                return true;
            else
                return false;
        }

        #endregion Metody
    }
}
