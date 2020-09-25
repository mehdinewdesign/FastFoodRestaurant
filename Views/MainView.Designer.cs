namespace FastFoodRestaurant
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.DriverPayButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TakeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeliveryButton = new System.Windows.Forms.Button();
            this.CollectionButton = new System.Windows.Forms.Button();
            this.EatButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainLogoPainel = new System.Windows.Forms.Panel();
            this.SubtitleMainView = new System.Windows.Forms.Label();
            this.MainTitle = new System.Windows.Forms.Label();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.homePromoControl1 = new FastFoodRestaurant.Views.HomePromoControl();
            this.eatControl1 = new FastFoodRestaurant.Views.UserControls.EatControl();
            this.MainPanel.SuspendLayout();
            this.MainLogoPainel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.SidePanel);
            this.MainPanel.Controls.Add(this.CustomersButton);
            this.MainPanel.Controls.Add(this.DriverPayButton);
            this.MainPanel.Controls.Add(this.button3);
            this.MainPanel.Controls.Add(this.TakeButton);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.DeliveryButton);
            this.MainPanel.Controls.Add(this.CollectionButton);
            this.MainPanel.Controls.Add(this.EatButton);
            this.MainPanel.Controls.Add(this.HomeButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(177, 591);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.TabStop = true;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(70, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 3;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 62);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 57);
            this.SidePanel.TabIndex = 3;
            // 
            // CustomersButton
            // 
            this.CustomersButton.FlatAppearance.BorderSize = 0;
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomersButton.Image")));
            this.CustomersButton.Location = new System.Drawing.Point(12, 423);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(165, 54);
            this.CustomersButton.TabIndex = 3;
            this.CustomersButton.Text = "      Customers";
            this.CustomersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // DriverPayButton
            // 
            this.DriverPayButton.FlatAppearance.BorderSize = 0;
            this.DriverPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverPayButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DriverPayButton.ForeColor = System.Drawing.Color.White;
            this.DriverPayButton.Image = ((System.Drawing.Image)(resources.GetObject("DriverPayButton.Image")));
            this.DriverPayButton.Location = new System.Drawing.Point(12, 363);
            this.DriverPayButton.Name = "DriverPayButton";
            this.DriverPayButton.Size = new System.Drawing.Size(165, 54);
            this.DriverPayButton.TabIndex = 3;
            this.DriverPayButton.Text = "      Driver Pay";
            this.DriverPayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DriverPayButton.UseVisualStyleBackColor = true;
            this.DriverPayButton.Click += new System.EventHandler(this.DriverPayButton_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(109, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 32);
            this.button3.TabIndex = 3;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TakeButton
            // 
            this.TakeButton.FlatAppearance.BorderSize = 0;
            this.TakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TakeButton.ForeColor = System.Drawing.Color.White;
            this.TakeButton.Image = ((System.Drawing.Image)(resources.GetObject("TakeButton.Image")));
            this.TakeButton.Location = new System.Drawing.Point(12, 303);
            this.TakeButton.Name = "TakeButton";
            this.TakeButton.Size = new System.Drawing.Size(165, 54);
            this.TakeButton.TabIndex = 3;
            this.TakeButton.Text = "      Take Away";
            this.TakeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TakeButton.UseVisualStyleBackColor = true;
            this.TakeButton.Click += new System.EventHandler(this.TakeButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 32);
            this.button1.TabIndex = 3;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DeliveryButton
            // 
            this.DeliveryButton.FlatAppearance.BorderSize = 0;
            this.DeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeliveryButton.ForeColor = System.Drawing.Color.White;
            this.DeliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("DeliveryButton.Image")));
            this.DeliveryButton.Location = new System.Drawing.Point(12, 243);
            this.DeliveryButton.Name = "DeliveryButton";
            this.DeliveryButton.Size = new System.Drawing.Size(165, 54);
            this.DeliveryButton.TabIndex = 3;
            this.DeliveryButton.Text = "      Delivery";
            this.DeliveryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeliveryButton.UseVisualStyleBackColor = true;
            this.DeliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
            // 
            // CollectionButton
            // 
            this.CollectionButton.FlatAppearance.BorderSize = 0;
            this.CollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollectionButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CollectionButton.ForeColor = System.Drawing.Color.White;
            this.CollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("CollectionButton.Image")));
            this.CollectionButton.Location = new System.Drawing.Point(12, 183);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(165, 54);
            this.CollectionButton.TabIndex = 3;
            this.CollectionButton.Text = "      Collection";
            this.CollectionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CollectionButton.UseVisualStyleBackColor = true;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // EatButton
            // 
            this.EatButton.FlatAppearance.BorderSize = 0;
            this.EatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EatButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EatButton.ForeColor = System.Drawing.Color.White;
            this.EatButton.Image = ((System.Drawing.Image)(resources.GetObject("EatButton.Image")));
            this.EatButton.Location = new System.Drawing.Point(12, 123);
            this.EatButton.Name = "EatButton";
            this.EatButton.Size = new System.Drawing.Size(165, 54);
            this.EatButton.TabIndex = 3;
            this.EatButton.Text = "      Eat-in";
            this.EatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EatButton.UseVisualStyleBackColor = true;
            this.EatButton.Click += new System.EventHandler(this.EatButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(12, 63);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(165, 54);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "      Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseCompatibleTextRendering = true;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(177, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(890, 10);
            this.TopPanel.TabIndex = 1;
            // 
            // MainLogoPainel
            // 
            this.MainLogoPainel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.MainLogoPainel.Controls.Add(this.SubtitleMainView);
            this.MainLogoPainel.Controls.Add(this.MainTitle);
            this.MainLogoPainel.Controls.Add(this.MainLogo);
            this.MainLogoPainel.Location = new System.Drawing.Point(230, 0);
            this.MainLogoPainel.Name = "MainLogoPainel";
            this.MainLogoPainel.Size = new System.Drawing.Size(109, 152);
            this.MainLogoPainel.TabIndex = 2;
            this.MainLogoPainel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SubtitleMainView
            // 
            this.SubtitleMainView.AutoSize = true;
            this.SubtitleMainView.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtitleMainView.ForeColor = System.Drawing.Color.White;
            this.SubtitleMainView.Location = new System.Drawing.Point(14, 117);
            this.SubtitleMainView.Name = "SubtitleMainView";
            this.SubtitleMainView.Size = new System.Drawing.Size(82, 17);
            this.SubtitleMainView.TabIndex = 3;
            this.SubtitleMainView.Text = "Restaurants";
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(13, 98);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(83, 19);
            this.MainTitle.TabIndex = 3;
            this.MainTitle.Text = "Fast foods";
            this.MainTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainLogo
            // 
            this.MainLogo.Image = ((System.Drawing.Image)(resources.GetObject("MainLogo.Image")));
            this.MainLogo.Location = new System.Drawing.Point(14, 16);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(70, 75);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainLogo.TabIndex = 4;
            this.MainLogo.TabStop = false;
            this.MainLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(37, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 42);
            this.button4.TabIndex = 3;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(100, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 42);
            this.button5.TabIndex = 3;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(818, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurations";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(162, 43);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // homePromoControl1
            // 
            this.homePromoControl1.Location = new System.Drawing.Point(177, 158);
            this.homePromoControl1.Name = "homePromoControl1";
            this.homePromoControl1.Size = new System.Drawing.Size(890, 433);
            this.homePromoControl1.TabIndex = 5;
            // 
            // eatControl1
            // 
            this.eatControl1.Location = new System.Drawing.Point(177, 158);
            this.eatControl1.Name = "eatControl1";
            this.eatControl1.Size = new System.Drawing.Size(890, 433);
            this.eatControl1.TabIndex = 6;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.eatControl1);
            this.Controls.Add(this.homePromoControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainLogoPainel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainLogoPainel.ResumeLayout(false);
            this.MainLogoPainel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainLogoPainel;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.Label SubtitleMainView;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button DriverPayButton;
        private System.Windows.Forms.Button TakeButton;
        private System.Windows.Forms.Button DeliveryButton;
        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Button EatButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Views.HomePromoControl homePromoControl1;
        private Views.UserControls.EatControl eatControl1;
        private System.Windows.Forms.Button CloseButton;
    }
}

