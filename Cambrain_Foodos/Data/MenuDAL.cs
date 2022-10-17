using System;
using System.Collections.Generic;
using Cambrain_Foodos.Models;

namespace Cambrain_Foodos.Data
{
    public class MenuDAL : IDisposable
    {
        public void Dispose()
        {

        }

       

        public List<Menu_items> getMenuItems()
        {
            using (MenuDBContext ctx = new MenuDBContext())
            {
                return ctx.MenuItems.ToList();
            }
        }

        public List<Menu_items> getItemsListByRestaurantID(int id)
        {
            using (MenuDBContext ctx = new MenuDBContext())
            {
                return ctx.MenuItems.Where(MenuItems => MenuItems.RestaurantId == id).ToList(); 
            }

        }



        public Menu_items getItemByRestaurantID(int id)
        {
            using (MenuDBContext ctx = new MenuDBContext())
            {
                return ctx.MenuItems.Where(MenuItems => MenuItems.RestaurantId == id).First();

            }

        }

        public Menu_items getItemByID(int id)
        {
            using (MenuDBContext ctx = new MenuDBContext())
            {
                return ctx.MenuItems.Where(item => item.ItemId == id).First();

            }

        }

        public void saveItems(Menu_items MenuItems)
        {
            using (MenuDBContext ctx = new MenuDBContext())
            {
                ctx.MenuItems.Add(MenuItems);
                ctx.SaveChanges();
            }
        }



        public MenuDAL()
        {
        }
    }
}
