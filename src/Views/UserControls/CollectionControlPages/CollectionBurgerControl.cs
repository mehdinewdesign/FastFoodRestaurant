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
        CollectionController collectionController = new CollectionController();
        
        public CollectionBurgerControl()
        {
            InitializeComponent();
        }

        private async void TraditionalBurgerBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => collectionController.DbEntryCollectionControl("Traditional Burger", 15, 1));
        }

        private async void SpecialTasteBurgerBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => collectionController.DbEntryCollectionControl("Special Taste", 23, 1));
        }

        private async void DarkBurgerBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => collectionController.DbEntryCollectionControl("Dark Burger", 27, 1));
        }
    }
}
