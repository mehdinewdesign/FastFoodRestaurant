using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using FastFoodRestaurant.Controllers;

namespace FastFoodRestaurant.Views.UserControls
{
    public partial class EatControl : UserControl
    {
        EatInController eatInController = new EatInController();
        
        public EatControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void EatControlBurgerBuy_Click(object sender, EventArgs e)
        {
            eatInController.DbEntryEatIn("Burger", 15, 1);
        }

        private void EatControlPastaBuy_Click(object sender, EventArgs e)
        {
            eatInController.DbEntryEatIn("Pasta", 22, 1);
        }

        private void EatControlCakeBuy_Click(object sender, EventArgs e)
        {
            eatInController.DbEntryEatIn("Cake", 50, 2);
        }
    }
}
