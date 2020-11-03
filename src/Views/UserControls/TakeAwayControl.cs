using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FastFoodRestaurant.Controllers;
using System.Threading.Tasks;

namespace FastFoodRestaurant.Views.UserControls
{
    public partial class TakeAwayControl : UserControl
    {
        UserControlController userControlController = new UserControlController();

        public TakeAwayControl()
        {
            InitializeComponent();
        }

        private async void PieceOfCakeBuyNowButton_Click(object sender, EventArgs e)
        {
            await Task.Run(() => userControlController.InsertProductsIntoDatabase("Piece of Cake", 5, 1));
        }
    }
}
