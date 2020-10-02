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


        // Set defautl state
        private void CollectionControl_Load(object sender, EventArgs e)
        {
            collectionBurgerControl.Visible = false;
            collectionPastaControl.Visible = false;
            collectionCakeControl.Visible = false;
            collectionPizzaControl.Visible = false;
            
        }


        // Change the state of user control view on click
        private void HamburguerCollectionButton_Click(object sender, EventArgs e)
        {
            collectionBurgerControl.BringToFront();
            collectionBurgerControl.Visible = true;
        }

        private void PastaCollectionButton_Click(object sender, EventArgs e)
        {
            collectionPastaControl.BringToFront();
            collectionPastaControl.Visible = true;
        }

        private void CakeCollectionButton_Click(object sender, EventArgs e)
        {
            collectionCakeControl.BringToFront();
            collectionCakeControl.Visible = true;
        }

        private void PizzaButton_Click(object sender, EventArgs e)
        {
            collectionPizzaControl.BringToFront();
            collectionPizzaControl.Visible = true;
        }

       

        private void CollectionItensGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void collectionBurgerControl_Load_1(object sender, EventArgs e)
        {
        }



        private void collectionCakeControl_Load(object sender, EventArgs e)
        {
        }

        private void collectionPizzaControl_Load(object sender, EventArgs e)
        {
        }


    }
}
