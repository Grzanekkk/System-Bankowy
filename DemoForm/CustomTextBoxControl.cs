using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class CustomTextBoxControl : UserControl
    {
        public string LabelText
        {
            get
            {
                return CustomLabel.Text;
            }
            set
            {
                CustomLabel.Text = value;
            }
        }

        public string TextBoxInput
        {
            get
            {
                return CustomTextBox.Text;
            }
            set
            {
                CustomTextBox.Text = value;
            }
        }


        public CustomTextBoxControl()
        {
            InitializeComponent();
        }
    }
}
