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
            this.HamburguerCollectionButton = new System.Windows.Forms.Button();
            this.PastaCollectionButton = new System.Windows.Forms.Button();
            this.CakeCollectionButton = new System.Windows.Forms.Button();
            this.PizzaCollectionButton = new System.Windows.Forms.Button();
            this.PizzaCollectionLabel = new System.Windows.Forms.Label();
            this.CakeCollectionLabel = new System.Windows.Forms.Label();
            this.PastaCollectionLabel = new System.Windows.Forms.Label();
            this.BurgerLabel = new System.Windows.Forms.Label();
            this.collectionCakeControl1 = new FastFoodRestaurant.Views.UserControls.CollectionControlPages.CollectionCakeControl();
            this.collectionPizzaControl1 = new FastFoodRestaurant.Views.UserControls.CollectionControlPages.CollectionPizzaControl();
            this.collectionBurgerControl = new FastFoodRestaurant.Views.UserControls.CollectionControlPages.CollectionBurgerControl();
            this.collectionPizzaControl = new FastFoodRestaurant.Views.UserControls.CollectionControlPages.CollectionPizzaControl();
            this.collectionCakeControl = new FastFoodRestaurant.Views.UserControls.CollectionControlPages.CollectionCakeControl();
            this.collectionPastaControl = new FastFoodRestaurant.Views.UserControls.CollectionControlPages.CollectionPastaControl();
            this.SuspendLayout();
            // 
            // HamburguerCollectionButton
            // 
            this.HamburguerCollectionButton.FlatAppearance.BorderSize = 0;
            this.HamburguerCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HamburguerCollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("HamburguerCollectionButton.Image")));
            this.HamburguerCollectionButton.Location = new System.Drawing.Point(264, 146);
            this.HamburguerCollectionButton.Name = "HamburguerCollectionButton";
            this.HamburguerCollectionButton.Size = new System.Drawing.Size(75, 72);
            this.HamburguerCollectionButton.TabIndex = 0;
            this.HamburguerCollectionButton.UseVisualStyleBackColor = true;
            this.HamburguerCollectionButton.Click += new System.EventHandler(this.HamburguerCollectionButton_Click);
            // 
            // PastaCollectionButton
            // 
            this.PastaCollectionButton.FlatAppearance.BorderSize = 0;
            this.PastaCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PastaCollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("PastaCollectionButton.Image")));
            this.PastaCollectionButton.Location = new System.Drawing.Point(363, 146);
            this.PastaCollectionButton.Name = "PastaCollectionButton";
            this.PastaCollectionButton.Size = new System.Drawing.Size(75, 72);
            this.PastaCollectionButton.TabIndex = 1;
            this.PastaCollectionButton.UseVisualStyleBackColor = true;
            this.PastaCollectionButton.Click += new System.EventHandler(this.PastaCollectionButton_Click);
            // 
            // CakeCollectionButton
            // 
            this.CakeCollectionButton.FlatAppearance.BorderSize = 0;
            this.CakeCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CakeCollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("CakeCollectionButton.Image")));
            this.CakeCollectionButton.Location = new System.Drawing.Point(462, 146);
            this.CakeCollectionButton.Name = "CakeCollectionButton";
            this.CakeCollectionButton.Size = new System.Drawing.Size(75, 72);
            this.CakeCollectionButton.TabIndex = 2;
            this.CakeCollectionButton.UseVisualStyleBackColor = true;
            this.CakeCollectionButton.Click += new System.EventHandler(this.CakeCollectionButton_Click);
            // 
            // PizzaCollectionButton
            // 
            this.PizzaCollectionButton.FlatAppearance.BorderSize = 0;
            this.PizzaCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PizzaCollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("PizzaCollectionButton.Image")));
            this.PizzaCollectionButton.Location = new System.Drawing.Point(554, 146);
            this.PizzaCollectionButton.Name = "PizzaCollectionButton";
            this.PizzaCollectionButton.Size = new System.Drawing.Size(75, 72);
            this.PizzaCollectionButton.TabIndex = 3;
            this.PizzaCollectionButton.UseVisualStyleBackColor = true;
            this.PizzaCollectionButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // PizzaCollectionLabel
            // 
            this.PizzaCollectionLabel.AutoSize = true;
            this.PizzaCollectionLabel.Location = new System.Drawing.Point(573, 221);
            this.PizzaCollectionLabel.Name = "PizzaCollectionLabel";
            this.PizzaCollectionLabel.Size = new System.Drawing.Size(33, 15);
            this.PizzaCollectionLabel.TabIndex = 4;
            this.PizzaCollectionLabel.Text = "Pizza";
            // 
            // CakeCollectionLabel
            // 
            this.CakeCollectionLabel.AutoSize = true;
            this.CakeCollectionLabel.Location = new System.Drawing.Point(482, 221);
            this.CakeCollectionLabel.Name = "CakeCollectionLabel";
            this.CakeCollectionLabel.Size = new System.Drawing.Size(33, 15);
            this.CakeCollectionLabel.TabIndex = 5;
            this.CakeCollectionLabel.Text = "Cake";
            // 
            // PastaCollectionLabel
            // 
            this.PastaCollectionLabel.AutoSize = true;
            this.PastaCollectionLabel.Location = new System.Drawing.Point(384, 221);
            this.PastaCollectionLabel.Name = "PastaCollectionLabel";
            this.PastaCollectionLabel.Size = new System.Drawing.Size(35, 15);
            this.PastaCollectionLabel.TabIndex = 6;
            this.PastaCollectionLabel.Text = "Pasta";
            // 
            // BurgerLabel
            // 
            this.BurgerLabel.AutoSize = true;
            this.BurgerLabel.Location = new System.Drawing.Point(267, 221);
            this.BurgerLabel.Name = "BurgerLabel";
            this.BurgerLabel.Size = new System.Drawing.Size(68, 15);
            this.BurgerLabel.TabIndex = 7;
            this.BurgerLabel.Text = "Hamburger";
            // 
            // collectionCakeControl1
            // 
            this.collectionCakeControl1.Location = new System.Drawing.Point(2008, 151);
            this.collectionCakeControl1.Name = "collectionCakeControl1";
            this.collectionCakeControl1.Size = new System.Drawing.Size(890, 433);
            this.collectionCakeControl1.TabIndex = 9;
            // 
            // collectionPizzaControl1
            // 
            this.collectionPizzaControl1.Location = new System.Drawing.Point(2898, 66);
            this.collectionPizzaControl1.Name = "collectionPizzaControl1";
            this.collectionPizzaControl1.Size = new System.Drawing.Size(890, 433);
            this.collectionPizzaControl1.TabIndex = 11;
            // 
            // collectionBurgerControl
            // 
            this.collectionBurgerControl.Location = new System.Drawing.Point(270, 266);
            this.collectionBurgerControl.Name = "collectionBurgerControl";
            this.collectionBurgerControl.Size = new System.Drawing.Size(890, 433);
            this.collectionBurgerControl.TabIndex = 12;
            this.collectionBurgerControl.Load += new System.EventHandler(this.collectionBurgerControl_Load_1);
            // 
            // collectionPizzaControl
            // 
            this.collectionPizzaControl.Location = new System.Drawing.Point(267, 266);
            this.collectionPizzaControl.Name = "collectionPizzaControl";
            this.collectionPizzaControl.Size = new System.Drawing.Size(890, 433);
            this.collectionPizzaControl.TabIndex = 13;
            this.collectionPizzaControl.Load += new System.EventHandler(this.collectionPizzaControl_Load);
            // 
            // collectionCakeControl
            // 
            this.collectionCakeControl.Location = new System.Drawing.Point(267, 266);
            this.collectionCakeControl.Name = "collectionCakeControl";
            this.collectionCakeControl.Size = new System.Drawing.Size(890, 433);
            this.collectionCakeControl.TabIndex = 14;
            this.collectionCakeControl.Load += new System.EventHandler(this.collectionCakeControl_Load);
            // 
            // collectionPastaControl
            // 
            this.collectionPastaControl.Location = new System.Drawing.Point(267, 266);
            this.collectionPastaControl.Name = "collectionPastaControl";
            this.collectionPastaControl.Size = new System.Drawing.Size(890, 433);
            this.collectionPastaControl.TabIndex = 15;
            // 
            // CollectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.collectionPastaControl);
            this.Controls.Add(this.collectionCakeControl);
            this.Controls.Add(this.collectionPizzaControl);
            this.Controls.Add(this.collectionBurgerControl);
            this.Controls.Add(this.HamburguerCollectionButton);
            this.Controls.Add(this.CakeCollectionButton);
            this.Controls.Add(this.CakeCollectionLabel);
            this.Controls.Add(this.collectionPizzaControl1);
            this.Controls.Add(this.PizzaCollectionLabel);
            this.Controls.Add(this.BurgerLabel);
            this.Controls.Add(this.collectionCakeControl1);
            this.Controls.Add(this.PizzaCollectionButton);
            this.Controls.Add(this.PastaCollectionButton);
            this.Controls.Add(this.PastaCollectionLabel);
            this.Name = "CollectionControl";
            this.Size = new System.Drawing.Size(890, 433);
            this.Load += new System.EventHandler(this.CollectionControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HamburguerCollectionButton;
        private System.Windows.Forms.Button PastaCollectionButton;
        private System.Windows.Forms.Button CakeCollectionButton;
        private System.Windows.Forms.Button PizzaCollectionButton;
        private System.Windows.Forms.Label PizzaCollectionLabel;
        private System.Windows.Forms.Label CakeCollectionLabel;
        private System.Windows.Forms.Label PastaCollectionLabel;
        private System.Windows.Forms.Label BurgerLabel;
        private CollectionControlPages.CollectionCakeControl collectionCakeControl1;
        private CollectionControlPages.CollectionPizzaControl collectionPizzaControl1;
        private CollectionControlPages.CollectionBurgerControl collectionBurgerControl;
        private CollectionControlPages.CollectionPizzaControl collectionPizzaControl;
        private CollectionControlPages.CollectionCakeControl collectionCakeControl;
        private CollectionControlPages.CollectionPastaControl collectionPastaControl;
    }
}
