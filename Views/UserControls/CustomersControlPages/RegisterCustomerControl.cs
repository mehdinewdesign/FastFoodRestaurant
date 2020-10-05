using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Models;
using FastFoodRestaurant.Controllers;

namespace FastFoodRestaurant.Views.UserControls.CustomersControlPages
{
    public partial class RegisterCustomerControl : UserControl
    {
        CollectionController collectionController = new CollectionController();
        RegisterCustomerController registerController = new RegisterCustomerController();
        public RegisterCustomerControl()
        {
            InitializeComponent();
            RegisterSuccessPopUp.Visible = false;
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
            registerController.DbEntryRecordRegister
            (
                NameTextBoxRegister.Text,
                UserNameTextBox.Text,
                PasswordTextBoxRegister.Text,
                EmailTextBoxRegister.Text
            );

            NameTextBoxRegister.Clear();
            UserNameTextBox.Clear();
            PasswordTextBoxRegister.Clear();
            EmailTextBoxRegister.Clear();

            RegisterSuccessPopUp.BringToFront();
            RegisterSuccessPopUp.Visible = true;
        }
    }
}
