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
    public partial class CollectionPastaControl : UserControl
    {
        UserControlController usercollectionController = new UserControlController();

        public CollectionPastaControl()
        {
            InitializeComponent();
        }

        private async void PizzaCollectionsBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Pizza", 15, 1));
        }

        private async void LasagnaCollectionsBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Lasagna", 20, 1));
        }

        private async void SpaghettiBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Spaghetti", 23, 1));
        }
    }
}
