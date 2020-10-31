using FastFoodRestaurant.Models;
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
            if (collectionObject.Visible == true)
            {
                collectionObject.Visible = false;
            }
        }

        public void DbEntryCollectionControl(string name, decimal price, byte points)
        {
            var registerContext = new EntityContext();

            var entryRecord = new Products
            {
                Name = name,
                Price = price,
                Points = points
            };

            registerContext.Add<Products>(entryRecord);
            registerContext.SaveChanges();
        }
    }
}