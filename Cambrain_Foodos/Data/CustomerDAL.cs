using System;
using System.Collections.Generic;
using Cambrain_Foodos.Models;

namespace Cambrain_Foodos.Data
{
    public class CustomerDAL : IDisposable
    {
        public void Dispose()
        {

        }

       


       


        public void saveItems(Customer customer)
        {
            using (CustomerDBContext ctx = new CustomerDBContext())
            {
                ctx.customer.Add(customer);
                ctx.SaveChanges();
            }
        }



        public CustomerDAL()
        {
        }
    }
}
