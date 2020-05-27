namespace DemoForm
{
    partial class CustomTextBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomLabel = new System.Windows.Forms.Label();
            this.CustomTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CustomLabel);
            this.panel1.Controls.Add(this.CustomTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 33);
            this.panel1.TabIndex = 4;
            // 
            // CustomLabel
            // 
            this.CustomLabel.AutoSize = true;
            this.CustomLabel.Location = new System.Drawing.Point(3, 7);
            this.CustomLabel.Name = "CustomLabel";
            this.CustomLabel.Size = new System.Drawing.Size(35, 13);
            this.CustomLabel.TabIndex = 1;
            this.CustomLabel.Text = "label1";
            // 
            // CustomTextBox
            // 
            this.CustomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomTextBox.BackColor = System.Drawing.Color.White;
            this.CustomTextBox.Location = new System.Drawing.Point(169, 4);
            this.CustomTextBox.Name = "CustomTextBox";
            this.CustomTextBox.ReadOnly = true;
            this.CustomTextBox.Size = new System.Drawing.Size(185, 20);
            this.CustomTextBox.TabIndex = 2;
            // 
            // CustomTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomTextBoxControl";
            this.Size = new System.Drawing.Size(362, 33);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CustomLabel;
        private System.Windows.Forms.TextBox CustomTextBox;
    }
}
