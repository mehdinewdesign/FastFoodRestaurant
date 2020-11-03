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
    public partial class CollectionPizzaControl : UserControl
    {
        UserControlController usercollectionController = new UserControlController();

        public CollectionPizzaControl()
        {
            InitializeComponent();
        }

        private async void VeggieCollectionBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Veggie Pizza", 15, 1));
        }

        private async void PepperoniCollectionBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Pepperoni Pizza", 23, 1));
        }

        private async void HawaiianCollectionBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => usercollectionController.InsertProductsIntoDatabase("Hawaiian Pizza", 27, 1));
        }
    }
}
