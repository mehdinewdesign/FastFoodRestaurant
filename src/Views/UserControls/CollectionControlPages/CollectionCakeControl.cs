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
    public partial class CollectionCakeControl : UserControl
    {

        CollectionController collectionController = new CollectionController();

        public CollectionCakeControl()
        {
            InitializeComponent();
        }

        private void YellowButterCollectionBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Yellow Butter Cake", 25, 3);
        }

        private void PoundCollectionBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Pound Cake", 30, 3);
        }

        private void RedVelvetCollectionBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Red Velvet Cake", 27, 3);
        }
    }
}
