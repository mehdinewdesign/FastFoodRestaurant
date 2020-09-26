namespace FastFoodRestaurant.Views.UserControls
{
    partial class CollectionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionControl));
            this.HamburguerButton = new System.Windows.Forms.Button();
            this.PastaButton = new System.Windows.Forms.Button();
            this.CakeButton = new System.Windows.Forms.Button();
            this.PizzaButton = new System.Windows.Forms.Button();
            this.PizzaCollectionLabel = new System.Windows.Forms.Label();
            this.CakeCollectionLabel = new System.Windows.Forms.Label();
            this.PastaCollectionLabel = new System.Windows.Forms.Label();
            this.BurgerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HamburguerButton
            // 
            this.HamburguerButton.FlatAppearance.BorderSize = 0;
            this.HamburguerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HamburguerButton.Image = ((System.Drawing.Image)(resources.GetObject("HamburguerButton.Image")));
            this.HamburguerButton.Location = new System.Drawing.Point(259, 138);
            this.HamburguerButton.Name = "HamburguerButton";
            this.HamburguerButton.Size = new System.Drawing.Size(75, 72);
            this.HamburguerButton.TabIndex = 0;
            this.HamburguerButton.UseVisualStyleBackColor = true;
            // 
            // PastaButton
            // 
            this.PastaButton.FlatAppearance.BorderSize = 0;
            this.PastaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PastaButton.Image = ((System.Drawing.Image)(resources.GetObject("PastaButton.Image")));
            this.PastaButton.Location = new System.Drawing.Point(362, 138);
            this.PastaButton.Name = "PastaButton";
            this.PastaButton.Size = new System.Drawing.Size(75, 72);
            this.PastaButton.TabIndex = 1;
            this.PastaButton.UseVisualStyleBackColor = true;
            // 
            // CakeButton
            // 
            this.CakeButton.FlatAppearance.BorderSize = 0;
            this.CakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CakeButton.Image = ((System.Drawing.Image)(resources.GetObject("CakeButton.Image")));
            this.CakeButton.Location = new System.Drawing.Point(460, 138);
            this.CakeButton.Name = "CakeButton";
            this.CakeButton.Size = new System.Drawing.Size(75, 72);
            this.CakeButton.TabIndex = 2;
            this.CakeButton.UseVisualStyleBackColor = true;
            // 
            // PizzaButton
            // 
            this.PizzaButton.FlatAppearance.BorderSize = 0;
            this.PizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PizzaButton.Image = ((System.Drawing.Image)(resources.GetObject("PizzaButton.Image")));
            this.PizzaButton.Location = new System.Drawing.Point(558, 138);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(75, 72);
            this.PizzaButton.TabIndex = 3;
            this.PizzaButton.UseVisualStyleBackColor = true;
            this.PizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // PizzaCollectionLabel
            // 
            this.PizzaCollectionLabel.AutoSize = true;
            this.PizzaCollectionLabel.Location = new System.Drawing.Point(576, 213);
            this.PizzaCollectionLabel.Name = "PizzaCollectionLabel";
            this.PizzaCollectionLabel.Size = new System.Drawing.Size(38, 15);
            this.PizzaCollectionLabel.TabIndex = 4;
            this.PizzaCollectionLabel.Text = "Pizzas";
            // 
            // CakeCollectionLabel
            // 
            this.CakeCollectionLabel.AutoSize = true;
            this.CakeCollectionLabel.Location = new System.Drawing.Point(478, 213);
            this.CakeCollectionLabel.Name = "CakeCollectionLabel";
            this.CakeCollectionLabel.Size = new System.Drawing.Size(38, 15);
            this.CakeCollectionLabel.TabIndex = 5;
            this.CakeCollectionLabel.Text = "Cakes";
            // 
            // PastaCollectionLabel
            // 
            this.PastaCollectionLabel.AutoSize = true;
            this.PastaCollectionLabel.Location = new System.Drawing.Point(380, 213);
            this.PastaCollectionLabel.Name = "PastaCollectionLabel";
            this.PastaCollectionLabel.Size = new System.Drawing.Size(35, 15);
            this.PastaCollectionLabel.TabIndex = 6;
            this.PastaCollectionLabel.Text = "Pasta";
            // 
            // BurgerLabel
            // 
            this.BurgerLabel.AutoSize = true;
            this.BurgerLabel.Location = new System.Drawing.Point(262, 213);
            this.BurgerLabel.Name = "BurgerLabel";
            this.BurgerLabel.Size = new System.Drawing.Size(68, 15);
            this.BurgerLabel.TabIndex = 7;
            this.BurgerLabel.Text = "Hamburger";
            // 
            // CollectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BurgerLabel);
            this.Controls.Add(this.PastaCollectionLabel);
            this.Controls.Add(this.CakeCollectionLabel);
            this.Controls.Add(this.PizzaCollectionLabel);
            this.Controls.Add(this.PizzaButton);
            this.Controls.Add(this.CakeButton);
            this.Controls.Add(this.PastaButton);
            this.Controls.Add(this.HamburguerButton);
            this.Name = "CollectionControl";
            this.Size = new System.Drawing.Size(890, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HamburguerButton;
        private System.Windows.Forms.Button PastaButton;
        private System.Windows.Forms.Button CakeButton;
        private System.Windows.Forms.Button PizzaButton;
        private System.Windows.Forms.Label PizzaCollectionLabel;
        private System.Windows.Forms.Label CakeCollectionLabel;
        private System.Windows.Forms.Label PastaCollectionLabel;
        private System.Windows.Forms.Label BurgerLabel;
    }
}
