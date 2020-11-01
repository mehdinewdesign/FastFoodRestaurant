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
    public partial class CollectionPizzaControl : UserControl
    {
        CollectionController collectionController = new CollectionController();

        public CollectionPizzaControl()
        {
            InitializeComponent();
        }

        private void VeggieCollectionBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Veggie Pizza", 15, 1);
        }

        private void PepperoniCollectionBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Pepperoni Pizza", 23, 1);
        }

        private void HawaiianCollectionBuyNow_Click(object sender, EventArgs e)
        {
            collectionController.DbEntryCollectionControl("Hawaiian Pizza", 27, 1);
        }
    }
}
