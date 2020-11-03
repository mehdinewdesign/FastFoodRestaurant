using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using FastFoodRestaurant.Controllers;
using System.Threading.Tasks;

namespace FastFoodRestaurant.Views.UserControls
{
    public partial class EatControl : UserControl
    {
        UserControlController usercollectionController = new UserControlController();

        public EatControl()
        {
            InitializeComponent();
        }

        private async void EatControlBurgerBuy_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Burger", 15, 1));
        }

        private async void EatControlPastaBuy_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Pasta", 22, 1));
        }

        private async void EatControlCakeBuy_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Cake", 50, 2));
        }
    }
}
