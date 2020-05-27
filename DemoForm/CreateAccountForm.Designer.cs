namespace DemoForm
{
    partial class CreateAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(119, 13);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(119, 40);
            this.BirthDatePicker.MaxDate = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1909, 12, 25, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDatePicker.TabIndex = 2;
            this.BirthDatePicker.Value = new System.DateTime(2000, 5, 17, 0, 0, 0, 0);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 46);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(119, 67);
            this.mtxtPhoneNumber.Mask = "+99 000000000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.mtxtPhoneNumber.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 70);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(119, 94);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(200, 157);
            this.rtxtAddress.TabIndex = 6;
            this.rtxtAddress.Text = "";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 94);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.LightGreen;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateAccount.Location = new System.Drawing.Point(142, 257);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(150, 36);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Checked = true;
            this.cbPhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPhone.Location = new System.Drawing.Point(326, 70);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(15, 14);
            this.cbPhone.TabIndex = 9;
            this.cbPhone.UseVisualStyleBackColor = true;
            this.cbPhone.CheckedChanged += new System.EventHandler(this.cbPhone_CheckedChanged);
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.Checked = true;
            this.cbAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddress.Location = new System.Drawing.Point(326, 97);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(15, 14);
            this.cbAddress.TabIndex = 10;
            this.cbAddress.UseVisualStyleBackColor = true;
            this.cbAddress.CheckedChanged += new System.EventHandler(this.cbAddress_CheckedChanged);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 305);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.cbPhone);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.CheckBox cbAddress;
    }
}