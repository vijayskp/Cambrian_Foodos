using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cambrain_Foodos.Models
{
    public partial class Menu_items
    {
        [Key]
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int? ItemPrice { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemImage { get;  set; }
        public int RestaurantId { get; set; }
    }
}
