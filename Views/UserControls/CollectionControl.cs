using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Views.UserControls.CollectionControlPages;

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
        }

        private void HamburguerCollectionButton_Click(object sender, EventArgs e)
        {
            collectionBurgerControl1.BringToFront();
        }

        private void CollectionItensGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void collectionBurgerControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void collectionCakeControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void collectionBurgerControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void PastaButton_Click(object sender, EventArgs e)
        {
            collectionBurgerControl1.BringToFront();
        }

        private void CakeButton_Click(object sender, EventArgs e)
        {
            collectionCakeControl1.BringToFront();
        }
    }
}
