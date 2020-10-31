using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Controllers;

namespace FastFoodRestaurant.Views
{
    public partial class HomePromoControl : UserControl
    {
        HomePromoControlController homepromoController = new HomePromoControlController();

        public HomePromoControl()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HomePromoControl_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomePromoControlOrderNow_Click(object sender, EventArgs e)
        {
            homepromoController.DbEntryRecordRegister("Burger", 19, 1);
        }
    }
}
