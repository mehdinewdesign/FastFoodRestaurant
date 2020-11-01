namespace FastFoodRestaurant.Views.UserControls
{
    partial class ShoppingCartControl
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
            this.ShoppingCartLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ShoppingCartLabel
            // 
            this.ShoppingCartLabel.AutoSize = true;
            this.ShoppingCartLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShoppingCartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(44)))));
            this.ShoppingCartLabel.Location = new System.Drawing.Point(30, 12);
            this.ShoppingCartLabel.Name = "ShoppingCartLabel";
            this.ShoppingCartLabel.Size = new System.Drawing.Size(270, 33);
            this.ShoppingCartLabel.TabIndex = 0;
            this.ShoppingCartLabel.Text = "Shopping Cart Itens";
            // 
            // ShoppingCartListView
            // 
            this.ShoppingCartListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShoppingCartListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShoppingCartListView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShoppingCartListView.HideSelection = false;
            this.ShoppingCartListView.Location = new System.Drawing.Point(30, 61);
            this.ShoppingCartListView.Name = "ShoppingCartListView";
            this.ShoppingCartListView.Size = new System.Drawing.Size(832, 343);
            this.ShoppingCartListView.TabIndex = 1;
            this.ShoppingCartListView.UseCompatibleStateImageBehavior = false;
            this.ShoppingCartListView.SelectedIndexChanged += new System.EventHandler(this.ShoppingCartListView_SelectedIndexChanged);
            // 
            // ShoppingCartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShoppingCartListView);
            this.Controls.Add(this.ShoppingCartLabel);
            this.Name = "ShoppingCartControl";
            this.Size = new System.Drawing.Size(890, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShoppingCartLabel;
        private System.Windows.Forms.ListView ShoppingCartListView;
    }
}
