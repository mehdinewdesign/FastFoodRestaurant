using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Models;

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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var registerContext = new EntityContext();

            var entryRecord = new Customers()
            {
                Name = NameTextBoxRegister.Text,
                UserName = UserNameTextBox.Text,
                Password = PasswordTextBoxRegister.Text,
                Email = EmailTextBoxRegister.Text
            };

            registerContext.Add<Customers>(entryRecord);

            registerContext.SaveChanges();
           
        }
    }
}
