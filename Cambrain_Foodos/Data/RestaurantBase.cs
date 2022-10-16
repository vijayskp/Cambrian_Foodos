
using Cambrain_Foodos.Models;
using Cambrain_Foodos.Data;
using Microsoft.AspNetCore.Components;
using System;

namespace RestaurantBase
{
   
    public class RestaurantBase : ComponentBase
    {
        public Restaurant Restaurant
        {
            get;
            set;
        }
        protected override Task OnInitializedAsync()
        {
            Restaurant = new Restaurant();
            return base.OnInitializedAsync();
        }
        public List<Restaurant> GetRestaurants()
        {
            using (FoodOrderingDAL dal = new FoodOrderingDAL())
            {
                List<Restaurant> restaurants = dal.getRestaurants();
                return restaurants;
            }
        }

    }
}
