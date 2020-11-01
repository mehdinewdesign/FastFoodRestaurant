namespace FastFoodRestaurant.Views.UserControls
{
    partial class DriverPayControl
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
            this.DeliveryControlSelectedItens = new System.Windows.Forms.ListView();
            this.DeliveryControlSelectedItensLabel = new System.Windows.Forms.Label();
            this.LicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.LicensePlateLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeliveryControlSelectedItens
            // 
            this.DeliveryControlSelectedItens.HideSelection = false;
            this.DeliveryControlSelectedItens.Location = new System.Drawing.Point(15, 54);
            this.DeliveryControlSelectedItens.Name = "DeliveryControlSelectedItens";
            this.DeliveryControlSelectedItens.Size = new System.Drawing.Size(861, 85);
            this.DeliveryControlSelectedItens.TabIndex = 3;
            this.DeliveryControlSelectedItens.UseCompatibleStateImageBehavior = false;
            // 
            // DeliveryControlSelectedItensLabel
            // 
            this.DeliveryControlSelectedItensLabel.AutoSize = true;
            this.DeliveryControlSelectedItensLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeliveryControlSelectedItensLabel.Location = new System.Drawing.Point(15, 15);
            this.DeliveryControlSelectedItensLabel.Name = "DeliveryControlSelectedItensLabel";
            this.DeliveryControlSelectedItensLabel.Size = new System.Drawing.Size(125, 21);
            this.DeliveryControlSelectedItensLabel.TabIndex = 1;
            this.DeliveryControlSelectedItensLabel.Text = "Selected Itens:";
            // 
            // LicensePlateTextBox
            // 
            this.LicensePlateTextBox.Location = new System.Drawing.Point(103, 163);
            this.LicensePlateTextBox.Name = "LicensePlateTextBox";
            this.LicensePlateTextBox.Size = new System.Drawing.Size(148, 23);
            this.LicensePlateTextBox.TabIndex = 4;
            // 
            // LicensePlateLabel
            // 
            this.LicensePlateLabel.AutoSize = true;
            this.LicensePlateLabel.Location = new System.Drawing.Point(22, 166);
            this.LicensePlateLabel.Name = "LicensePlateLabel";
            this.LicensePlateLabel.Size = new System.Drawing.Size(75, 15);
            this.LicensePlateLabel.TabIndex = 5;
            this.LicensePlateLabel.Text = "License Plate";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 217);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(861, 169);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(861, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DriverPayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LicensePlateLabel);
            this.Controls.Add(this.LicensePlateTextBox);
            this.Controls.Add(this.DeliveryControlSelectedItensLabel);
            this.Controls.Add(this.DeliveryControlSelectedItens);
            this.Name = "DriverPayControl";
            this.Size = new System.Drawing.Size(890, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DeliveryControlSelectedItens;
        private System.Windows.Forms.Label DeliveryControlSelectedItensLabel;
        private System.Windows.Forms.TextBox LicensePlateTextBox;
        private System.Windows.Forms.Label LicensePlateLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}
