using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Controllers;

namespace FastFoodRestaurant.Views.UserControls.CollectionControlPages
{
    

    public partial class CollectionBurgerControl : UserControl
    {
        CollectionController collectionController = new CollectionController();
        
        public CollectionBurgerControl()
        {
            InitializeComponent();
        }

        private void TraditionalBurgerBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Traditional Burger", 15, 1);
        }

        private void SpecialTasteBurgerBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Special Taste", 23, 1);
        }

        private void DarkBurgerBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Dark Burger", 27, 1);
        }
    }
}
