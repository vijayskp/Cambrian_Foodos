using System;
using System.Collections.Generic;
using Cambrain_Foodos.Models;

namespace Cambrain_Foodos.Data
{
    public class ItemDAL : IDisposable
    {
        public void Dispose()
        {

        }

       

        public List<order_details> getOrderDetails()
        {
            using (ItemDBContext ctx = new ItemDBContext())
            {
                return ctx.orderDetails.ToList();
            }
        }

       


        public void saveItems(order_details OrderDetails)
        {
            using (ItemDBContext ctx = new ItemDBContext())
            {
                ctx.orderDetails.Add(OrderDetails);
                ctx.SaveChanges();
            }
        }



        public ItemDAL()
        {
        }
    }
}
