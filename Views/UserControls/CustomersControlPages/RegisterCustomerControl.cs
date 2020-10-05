using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FastFoodRestaurant.Views.UserControls.CustomersControlPages
{
    public partial class RegisterCustomerControl : UserControl
    {
        public RegisterCustomerControl()
        {
            InitializeComponent();
        }

        private void RegisterCustomerControl_Load(object sender, EventArgs e)
        {
            // Configure Password text box.
            PasswordTextBoxRegister.Text = "";
            PasswordTextBoxRegister.PasswordChar = Char.Parse("*");
            PasswordTextBoxRegister.MaxLength = 164;

            NameTextBoxRegister.TabIndex = 0;
            UserNameTextBox.TabIndex = 1;
            PasswordTextBoxRegister.TabIndex = 2;
            EmailTextBoxRegister.TabIndex = 3;
        }

        private void NameTextBoxRegister_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
