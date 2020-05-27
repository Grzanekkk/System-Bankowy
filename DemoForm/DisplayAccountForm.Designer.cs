namespace DemoForm
{
    partial class DisplayAccountForm
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
            this.TransactionListBox = new System.Windows.Forms.ListBox();
            this.AmountOfTransactionTextBox = new System.Windows.Forms.TextBox();
            this.TransactionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MakeTransactionButton = new System.Windows.Forms.Button();
            this.CurrentBalancePanel = new DemoForm.CustomTextBoxControl();
            this.TransactionLocationPanel = new DemoForm.CustomTextBoxControl();
            this.TransactionDatePanel = new DemoForm.CustomTextBoxControl();
            this.TransactionAmountPanel = new DemoForm.CustomTextBoxControl();
            this.TransactionTypePanel = new DemoForm.CustomTextBoxControl();
            this.CustomerNamePanel = new DemoForm.CustomTextBoxControl();
            this.SuspendLayout();
            // 
            // TransactionListBox
            // 
            this.TransactionListBox.FormattingEnabled = true;
            this.TransactionListBox.Items.AddRange(new object[] {
            "Transaction 1",
            "Transaction 2"});
            this.TransactionListBox.Location = new System.Drawing.Point(13, 13);
            this.TransactionListBox.Name = "TransactionListBox";
            this.TransactionListBox.Size = new System.Drawing.Size(265, 368);
            this.TransactionListBox.TabIndex = 0;
            this.TransactionListBox.SelectedIndexChanged += new System.EventHandler(this.TransactionListBox_SelectedIndexChanged);
            // 
            // AmountOfTransactionTextBox
            // 
            this.AmountOfTransactionTextBox.Location = new System.Drawing.Point(13, 387);
            this.AmountOfTransactionTextBox.Name = "AmountOfTransactionTextBox";
            this.AmountOfTransactionTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountOfTransactionTextBox.TabIndex = 6;
            this.AmountOfTransactionTextBox.Text = "1000";
            // 
            // TransactionTypeComboBox
            // 
            this.TransactionTypeComboBox.FormattingEnabled = true;
            this.TransactionTypeComboBox.Location = new System.Drawing.Point(138, 387);
            this.TransactionTypeComboBox.Name = "TransactionTypeComboBox";
            this.TransactionTypeComboBox.Size = new System.Drawing.Size(140, 21);
            this.TransactionTypeComboBox.TabIndex = 7;
            this.TransactionTypeComboBox.Text = "Choose transaction type";
            this.TransactionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionTypeComboBox_SelectedIndexChanged);
            // 
            // MakeTransactionButton
            // 
            this.MakeTransactionButton.BackColor = System.Drawing.Color.Red;
            this.MakeTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MakeTransactionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MakeTransactionButton.Location = new System.Drawing.Point(78, 413);
            this.MakeTransactionButton.Name = "MakeTransactionButton";
            this.MakeTransactionButton.Size = new System.Drawing.Size(116, 55);
            this.MakeTransactionButton.TabIndex = 8;
            this.MakeTransactionButton.Text = "Confirm Transaction";
            this.MakeTransactionButton.UseVisualStyleBackColor = false;
            this.MakeTransactionButton.Click += new System.EventHandler(this.MakeTransactionButton_Click);
            // 
            // CurrentBalancePanel
            // 
            this.CurrentBalancePanel.LabelText = "Current Balance";
            this.CurrentBalancePanel.Location = new System.Drawing.Point(361, 52);
            this.CurrentBalancePanel.Name = "CurrentBalancePanel";
            this.CurrentBalancePanel.Size = new System.Drawing.Size(362, 33);
            this.CurrentBalancePanel.TabIndex = 9;
            this.CurrentBalancePanel.TextBoxInput = "";
            // 
            // TransactionLocationPanel
            // 
            this.TransactionLocationPanel.LabelText = "Transactioni Location";
            this.TransactionLocationPanel.Location = new System.Drawing.Point(361, 274);
            this.TransactionLocationPanel.Name = "TransactionLocationPanel";
            this.TransactionLocationPanel.Size = new System.Drawing.Size(362, 33);
            this.TransactionLocationPanel.TabIndex = 5;
            this.TransactionLocationPanel.TextBoxInput = "";
            // 
            // TransactionDatePanel
            // 
            this.TransactionDatePanel.LabelText = "Transaction Date";
            this.TransactionDatePanel.Location = new System.Drawing.Point(361, 235);
            this.TransactionDatePanel.Name = "TransactionDatePanel";
            this.TransactionDatePanel.Size = new System.Drawing.Size(362, 33);
            this.TransactionDatePanel.TabIndex = 4;
            this.TransactionDatePanel.TextBoxInput = "";
            // 
            // TransactionAmountPanel
            // 
            this.TransactionAmountPanel.LabelText = "Transaction Amount";
            this.TransactionAmountPanel.Location = new System.Drawing.Point(361, 195);
            this.TransactionAmountPanel.Name = "TransactionAmountPanel";
            this.TransactionAmountPanel.Size = new System.Drawing.Size(362, 33);
            this.TransactionAmountPanel.TabIndex = 3;
            this.TransactionAmountPanel.TextBoxInput = "";
            // 
            // TransactionTypePanel
            // 
            this.TransactionTypePanel.LabelText = "Transaction Type";
            this.TransactionTypePanel.Location = new System.Drawing.Point(361, 155);
            this.TransactionTypePanel.Name = "TransactionTypePanel";
            this.TransactionTypePanel.Size = new System.Drawing.Size(362, 33);
            this.TransactionTypePanel.TabIndex = 2;
            this.TransactionTypePanel.TextBoxInput = "";
            // 
            // CustomerNamePanel
            // 
            this.CustomerNamePanel.LabelText = "Customer Name";
            this.CustomerNamePanel.Location = new System.Drawing.Point(361, 13);
            this.CustomerNamePanel.Name = "CustomerNamePanel";
            this.CustomerNamePanel.Size = new System.Drawing.Size(362, 33);
            this.CustomerNamePanel.TabIndex = 1;
            this.CustomerNamePanel.TextBoxInput = "";
            // 
            // DisplayAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 510);
            this.Controls.Add(this.CurrentBalancePanel);
            this.Controls.Add(this.MakeTransactionButton);
            this.Controls.Add(this.TransactionTypeComboBox);
            this.Controls.Add(this.AmountOfTransactionTextBox);
            this.Controls.Add(this.TransactionLocationPanel);
            this.Controls.Add(this.TransactionDatePanel);
            this.Controls.Add(this.TransactionAmountPanel);
            this.Controls.Add(this.TransactionTypePanel);
            this.Controls.Add(this.CustomerNamePanel);
            this.Controls.Add(this.TransactionListBox);
            this.Name = "DisplayAccountForm";
            this.Text = "Account Information";
            this.Load += new System.EventHandler(this.DisplayAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TransactionListBox;
        private CustomTextBoxControl CustomerNamePanel;
        private CustomTextBoxControl TransactionTypePanel;
        private CustomTextBoxControl TransactionAmountPanel;
        private CustomTextBoxControl TransactionDatePanel;
        private CustomTextBoxControl TransactionLocationPanel;
        private System.Windows.Forms.TextBox AmountOfTransactionTextBox;
        private System.Windows.Forms.ComboBox TransactionTypeComboBox;
        private System.Windows.Forms.Button MakeTransactionButton;
        private CustomTextBoxControl CurrentBalancePanel;
    }
}