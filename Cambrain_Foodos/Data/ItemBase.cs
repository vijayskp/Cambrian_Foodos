
using Cambrain_Foodos.Models;
using Cambrain_Foodos.Data;
using Microsoft.AspNetCore.Components;
using System;

namespace ItemBase
{
   
    public class ItemBase : ComponentBase
    {
        public order_details orderDetails
        {
            get;
            set;
        }
        protected override Task OnInitializedAsync()
        {
            orderDetails = new order_details();
            return base.OnInitializedAsync();
        }
        public List<order_details> getOrderDetails()
        {
            using (ItemDAL dal = new ItemDAL())
            {
                List<order_details> orderDetails = dal.getOrderDetails();
                return orderDetails;
            }
        }




        public void SaveItem()
        {
            using (ItemDAL dal = new ItemDAL())
            {
                dal.saveItems(orderDetails);
            }
        }





    }
}
