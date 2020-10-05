namespace FastFoodRestaurant.Views.UserControls.CustomersControlPages
{
    partial class RegisterCustomerControl
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
            this.NameLabelRegister = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.NameTextBoxRegister = new System.Windows.Forms.TextBox();
            this.EmailTextBoxRegister = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxRegister = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabelRegister = new System.Windows.Forms.Label();
            this.EmailLabelRegister = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabelRegister
            // 
            this.NameLabelRegister.AutoSize = true;
            this.NameLabelRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabelRegister.Location = new System.Drawing.Point(39, 69);
            this.NameLabelRegister.Name = "NameLabelRegister";
            this.NameLabelRegister.Size = new System.Drawing.Size(50, 17);
            this.NameLabelRegister.TabIndex = 0;
            this.NameLabelRegister.Text = "Name: ";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(39, 110);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(46, 17);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Login: ";
            // 
            // NameTextBoxRegister
            // 
            this.NameTextBoxRegister.Location = new System.Drawing.Point(126, 63);
            this.NameTextBoxRegister.Name = "NameTextBoxRegister";
            this.NameTextBoxRegister.Size = new System.Drawing.Size(260, 23);
            this.NameTextBoxRegister.TabIndex = 2;
            this.NameTextBoxRegister.TextChanged += new System.EventHandler(this.NameTextBoxRegister_TextChanged);
            // 
            // EmailTextBoxRegister
            // 
            this.EmailTextBoxRegister.Location = new System.Drawing.Point(126, 183);
            this.EmailTextBoxRegister.Name = "EmailTextBoxRegister";
            this.EmailTextBoxRegister.Size = new System.Drawing.Size(260, 23);
            this.EmailTextBoxRegister.TabIndex = 3;
            // 
            // PasswordTextBoxRegister
            // 
            this.PasswordTextBoxRegister.Location = new System.Drawing.Point(126, 143);
            this.PasswordTextBoxRegister.Name = "PasswordTextBoxRegister";
            this.PasswordTextBoxRegister.Size = new System.Drawing.Size(260, 23);
            this.PasswordTextBoxRegister.TabIndex = 5;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(126, 103);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(260, 23);
            this.UserNameTextBox.TabIndex = 6;
            // 
            // PasswordLabelRegister
            // 
            this.PasswordLabelRegister.AutoSize = true;
            this.PasswordLabelRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabelRegister.Location = new System.Drawing.Point(39, 149);
            this.PasswordLabelRegister.Name = "PasswordLabelRegister";
            this.PasswordLabelRegister.Size = new System.Drawing.Size(69, 17);
            this.PasswordLabelRegister.TabIndex = 7;
            this.PasswordLabelRegister.Text = "Password: ";
            // 
            // EmailLabelRegister
            // 
            this.EmailLabelRegister.AutoSize = true;
            this.EmailLabelRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabelRegister.Location = new System.Drawing.Point(39, 187);
            this.EmailLabelRegister.Name = "EmailLabelRegister";
            this.EmailLabelRegister.Size = new System.Drawing.Size(45, 17);
            this.EmailLabelRegister.TabIndex = 8;
            this.EmailLabelRegister.Text = "Email: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(126, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RegisterCustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailLabelRegister);
            this.Controls.Add(this.PasswordLabelRegister);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordTextBoxRegister);
            this.Controls.Add(this.EmailTextBoxRegister);
            this.Controls.Add(this.NameTextBoxRegister);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.NameLabelRegister);
            this.Name = "RegisterCustomerControl";
            this.Size = new System.Drawing.Size(890, 433);
            this.Load += new System.EventHandler(this.RegisterCustomerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabelRegister;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox NameTextBoxRegister;
        private System.Windows.Forms.TextBox EmailTextBoxRegister;
        private System.Windows.Forms.TextBox PasswordTextBoxRegister;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label PasswordLabelRegister;
        private System.Windows.Forms.Label EmailLabelRegister;
        private System.Windows.Forms.Button button1;
    }
}
