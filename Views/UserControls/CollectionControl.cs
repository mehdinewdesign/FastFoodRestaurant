using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Views.UserControls.CollectionControlPages;
using FastFoodRestaurant.Controllers;

namespace FastFoodRestaurant.Views.UserControls
{
    public partial class CollectionControl : UserControl
    {
        
        public CollectionControl()
        {
            InitializeComponent();
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            collectionPizzaControl1.BringToFront();
            collectionPizzaControl1.Visible = true;
        }

        private void HamburguerCollectionButton_Click(object sender, EventArgs e)
        {
            collectionBurgerControl.BringToFront();
            collectionBurgerControl.Visible = true;
        }

        private void CollectionItensGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void collectionBurgerControl_Load_1(object sender, EventArgs e)
        {
            collectionBurgerControl.BringToFront();
            collectionBurgerControl.Visible = true;
        }

        private void CollectionControl_Load(object sender, EventArgs e)
        {
            collectionBurgerControl.Visible = false;
            collectionCakeControl.Visible = false;
            collectionPizzaControl.Visible = false;
            collectionPastaControl.Visible = false;
        }

        private void collectionCakeControl_Load(object sender, EventArgs e)
        {
            collectionCakeControl.BringToFront();
            collectionCakeControl.Visible = true;
        }

        private void collectionPizzaControl_Load(object sender, EventArgs e)
        {
            collectionPizzaControl.BringToFront();
            collectionPizzaControl.Visible = true;
        }
    }
}
