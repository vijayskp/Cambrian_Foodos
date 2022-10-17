﻿
using Cambrain_Foodos.Models;
using Cambrain_Foodos.Data;
using Microsoft.AspNetCore.Components;
using System;

namespace MenuBase
{
   
    public class MenuBase : ComponentBase
    {
        public Menu_items MenuItems
        {
            get;
            set;
        }

        public order_details orderDetails
        {
            get;
            set;
        }

        protected override Task OnInitializedAsync()
        {
            MenuItems = new Menu_items();
            orderDetails = new order_details();
            return base.OnInitializedAsync();
        }
        public List<Menu_items> getMenuItems()
        {
            using (MenuDAL dal = new MenuDAL())
            {
                List<Menu_items> MenuItems = dal.getMenuItems();
                return MenuItems;
            }
        }

        public List<Menu_items> getItemsListByRestaurantID(int id)
        {
            using (MenuDAL dal = new MenuDAL())
            {
                List<Menu_items> MenuItems = dal.getItemsListByRestaurantID(id);
                return MenuItems;
            }
        }
       
        public void SaveItem()
        {
            using (ItemDAL dal = new ItemDAL())
            {
                dal.saveItems(orderDetails);
            }
        }


        public Menu_items GetItemByRestaurantID(int id)
        {
            using (MenuDAL dal = new MenuDAL())
            {
                Menu_items menuItems = dal.getItemByRestaurantID(id);
                return menuItems;
            }
        }



        public Menu_items GetItemByID(int id)
        {
            using (MenuDAL dal = new MenuDAL())
            {
                Menu_items item = dal.getItemByID(id);
                return item;
            }
        }




    }
}
