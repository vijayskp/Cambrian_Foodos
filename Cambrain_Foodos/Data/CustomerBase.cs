
using Cambrain_Foodos.Models;
using Cambrain_Foodos.Data;
using Microsoft.AspNetCore.Components;
using System;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CustomerBase
{
   
    public class CustomerBase : ComponentBase
    {
        public Customer customer
        {
            get;
            set;
        }
        protected override Task OnInitializedAsync()
        {
            customer = new Customer();
            return base.OnInitializedAsync();
        }
      




        public void SaveItem()
        {
            using (CustomerDAL dal = new CustomerDAL())
            {
                Console.WriteLine("customer data", customer);
                dal.saveItems(customer);
            }
        }

    }
}
