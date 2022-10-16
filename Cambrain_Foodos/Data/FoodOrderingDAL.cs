using System;
using Cambrain_Foodos.Models;

namespace Cambrain_Foodos.Data
{
    public class FoodOrderingDAL : IDisposable
    {
        public void Dispose()
        {

        }

       

        public List<Restaurant> getRestaurants()
        {
            using (FoodOrderingSystemDBContext ctx = new FoodOrderingSystemDBContext())
            {
                return ctx.Restaurants.ToList();
            }
        }

      
        public FoodOrderingDAL()
        {
        }
    }
}
