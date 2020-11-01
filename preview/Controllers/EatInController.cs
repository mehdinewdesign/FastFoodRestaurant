using FastFoodRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodRestaurant.Controllers
{
    public class EatInController
    {
        public void DbEntryEatIn(string name, decimal price, byte points)
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
