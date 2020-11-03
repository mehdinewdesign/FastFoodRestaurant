using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Controllers;
using System.Threading.Tasks;

namespace FastFoodRestaurant.Views.UserControls.CollectionControlPages
{
    

    public partial class CollectionBurgerControl : UserControl
    {
        UserControlController userControlController = new UserControlController();
        
        public CollectionBurgerControl()
        {
            InitializeComponent();
        }

        private async void TraditionalBurgerBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => userControlController.InsertProductsIntoDatabase("Traditional Burger", 15, 1));
        }

        private async void SpecialTasteBurgerBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => userControlController.InsertProductsIntoDatabase("Special Taste", 23, 1));
        }

        private async void DarkBurgerBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => userControlController.InsertProductsIntoDatabase("Dark Burger", 27, 1));
        }
    }
}
