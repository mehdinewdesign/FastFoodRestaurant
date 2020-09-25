using FastFoodRestaurant.Views;
using FastFoodRestaurant.Views.UserControls;
using System;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            HomePromoControl promo = new HomePromoControl();
            promo.BringToFront();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
           
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
           
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            HomePromoControl promo = new HomePromoControl();
            promo.BringToFront();
        }

        private void EatButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = EatButton.Height;
            SidePanel.Top = EatButton.Top;
            EatControl eat = new EatControl();
            eat.BringToFront();
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryButton_Click(object sender, EventArgs e)
        {

        }

        private void TakeButton_Click(object sender, EventArgs e)
        {

        }

        private void DriverPayButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            // var closeOption = new MainView();
            // closeOption.Close();
        }
    }
}
