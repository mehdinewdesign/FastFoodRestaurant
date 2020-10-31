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
    public partial class CollectionPastaControl : UserControl
    {
        CollectionController collectionController = new CollectionController();

        public CollectionPastaControl()
        {
            InitializeComponent();
        }

        private void PizzaCollectionsBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Pizza", 15, 1);
        }

        private void LasagnaCollectionsBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Lasagna", 20, 1);
        }

        private void SpaghettiBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Spaghetti", 23, 1);
        }
    }
}
