using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FastFoodRestaurant.Controllers
{
    class CollectionController
    {
        public void SetStateUserControlToFalse(Control collectionObject)
        { 
            if(collectionObject.Visible == true)
            {
                collectionObject.Visible = false;
            }
        }
    }
}
