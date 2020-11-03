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
    public partial class CollectionCakeControl : UserControl
    {

        CollectionController collectionController = new CollectionController();

        public CollectionCakeControl()
        {
            InitializeComponent();
        }

        private async void YellowButterCollectionBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => collectionController.DbEntryCollectionControl("Yellow Butter Cake", 25, 3));
        }

        private async void PoundCollectionBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => collectionController.DbEntryCollectionControl("Pound Cake", 30, 3));
        }

        private async void RedVelvetCollectionBuyNow_Click(object sender, EventArgs e)
        {
            await Task.Run(() => collectionController.DbEntryCollectionControl("Red Velvet Cake", 27, 3));
        }
    }
}
