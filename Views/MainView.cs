using FastFoodRestaurant.Controllers;
using FastFoodRestaurant.Views;
using FastFoodRestaurant.Views.UserControls;
using System;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class MainView : Form
    {
        // Initialize Controller.
        MainViewController mainController = new MainViewController();

        public MainView()
        {
            InitializeComponent();
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
            // A altura do SidePanel é equivalente à altura do HomeButton.
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            SidePanel.BringToFront();
        }

        private void EatButton_Click(object sender, EventArgs e)
        {
            mainController.SidePanelSwapOnClick(EatButton, SidePanel);
        }

        private void CollectionButton_Click(object sender, EventArgs e)
        {
            mainController.SidePanelSwapOnClick(CollectionButton, SidePanel);
        }

        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            mainController.SidePanelSwapOnClick(DeliveryButton, SidePanel);
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            mainController.SidePanelSwapOnClick(TakeButton, SidePanel);
        }

        private void DriverPayButton_Click(object sender, EventArgs e)
        {
            mainController.SidePanelSwapOnClick(DriverPayButton, SidePanel);
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            mainController.SidePanelSwapOnClick(CustomersButton, SidePanel);
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
        }
    }
}
