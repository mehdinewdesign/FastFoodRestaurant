using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FastFoodRestaurant.Controllers
{
    public class MainViewController
    {
        public void SidePanelSwapOnClick(Button buttonValue, Panel panelValue)
        {
            panelValue.Height = buttonValue.Height;
            panelValue.Top = buttonValue.Top;
            panelValue.BringToFront();
        }
    }
}
