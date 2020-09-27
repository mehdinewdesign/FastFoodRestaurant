namespace FastFoodRestaurant.Views.UserControls
{
    partial class DeliveryControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderDeliveryButton = new System.Windows.Forms.Button();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.PostalCodeAddressLabel = new System.Windows.Forms.Label();
            this.NumberAddresslabel = new System.Windows.Forms.Label();
            this.SupplyLabel = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.NumberAddressTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDeliveryButton
            // 
            this.OrderDeliveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(44)))));
            this.OrderDeliveryButton.FlatAppearance.BorderSize = 0;
            this.OrderDeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderDeliveryButton.ForeColor = System.Drawing.Color.White;
            this.OrderDeliveryButton.Location = new System.Drawing.Point(13, 390);
            this.OrderDeliveryButton.Name = "OrderDeliveryButton";
            this.OrderDeliveryButton.Size = new System.Drawing.Size(861, 23);
            this.OrderDeliveryButton.TabIndex = 0;
            this.OrderDeliveryButton.Text = "Check Out";
            this.OrderDeliveryButton.UseVisualStyleBackColor = false;
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedItemLabel.Location = new System.Drawing.Point(13, 16);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(108, 21);
            this.SelectedItemLabel.TabIndex = 1;
            this.SelectedItemLabel.Text = "Selected Itens:";
            this.SelectedItemLabel.Click += new System.EventHandler(this.SelectedItemLabel_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(861, 69);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.textBox2);
            this.AddressGroupBox.Controls.Add(this.textBox1);
            this.AddressGroupBox.Controls.Add(this.NumberAddressTextBox);
            this.AddressGroupBox.Controls.Add(this.StreetTextBox);
            this.AddressGroupBox.Controls.Add(this.SupplyLabel);
            this.AddressGroupBox.Controls.Add(this.NumberAddresslabel);
            this.AddressGroupBox.Controls.Add(this.PostalCodeAddressLabel);
            this.AddressGroupBox.Controls.Add(this.StreetLabel);
            this.AddressGroupBox.Location = new System.Drawing.Point(13, 115);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(861, 94);
            this.AddressGroupBox.TabIndex = 4;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Address:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(11, 27);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(43, 15);
            this.StreetLabel.TabIndex = 0;
            this.StreetLabel.Text = "Street: ";
            // 
            // PostalCodeAddressLabel
            // 
            this.PostalCodeAddressLabel.AutoSize = true;
            this.PostalCodeAddressLabel.Location = new System.Drawing.Point(638, 27);
            this.PostalCodeAddressLabel.Name = "PostalCodeAddressLabel";
            this.PostalCodeAddressLabel.Size = new System.Drawing.Size(34, 15);
            this.PostalCodeAddressLabel.TabIndex = 1;
            this.PostalCodeAddressLabel.Text = "CEP: ";
            // 
            // NumberAddresslabel
            // 
            this.NumberAddresslabel.AutoSize = true;
            this.NumberAddresslabel.Location = new System.Drawing.Point(469, 27);
            this.NumberAddresslabel.Name = "NumberAddresslabel";
            this.NumberAddresslabel.Size = new System.Drawing.Size(57, 15);
            this.NumberAddresslabel.TabIndex = 2;
            this.NumberAddresslabel.Text = "Number: ";
            this.NumberAddresslabel.Click += new System.EventHandler(this.NumberAddresslabel_Click);
            // 
            // SupplyLabel
            // 
            this.SupplyLabel.AutoSize = true;
            this.SupplyLabel.Location = new System.Drawing.Point(11, 62);
            this.SupplyLabel.Name = "SupplyLabel";
            this.SupplyLabel.Size = new System.Drawing.Size(83, 15);
            this.SupplyLabel.TabIndex = 3;
            this.SupplyLabel.Text = "Complement: ";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(13, 215);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(861, 169);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(100, 19);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(357, 23);
            this.StreetTextBox.TabIndex = 4;
            // 
            // NumberAddressTextBox
            // 
            this.NumberAddressTextBox.Location = new System.Drawing.Point(532, 19);
            this.NumberAddressTextBox.Name = "NumberAddressTextBox";
            this.NumberAddressTextBox.Size = new System.Drawing.Size(100, 23);
            this.NumberAddressTextBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(755, 23);
            this.textBox2.TabIndex = 7;
            // 
            // DeliveryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.AddressGroupBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.OrderDeliveryButton);
            this.Name = "DeliveryControl";
            this.Size = new System.Drawing.Size(890, 433);
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderDeliveryButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox AddressGroupBox;
        private System.Windows.Forms.Label SupplyLabel;
        private System.Windows.Forms.Label NumberAddresslabel;
        private System.Windows.Forms.Label PostalCodeAddressLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox NumberAddressTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
