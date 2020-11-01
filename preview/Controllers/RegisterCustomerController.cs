using FastFoodRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FastFoodRestaurant.Controllers
{
    public class RegisterCustomerController
    {
        public void DbEntryRecordRegister(string name, string userName, string password, string email)
        {
            var registerContext = new EntityContext();

            var entryRecord = new Customers()
            {
                Name = name,
                UserName = userName,
                Password = password,
                Email = email
            };

            registerContext.Add<Customers>(entryRecord);
            registerContext.SaveChanges();
        }
    }
}
