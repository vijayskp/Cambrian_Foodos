using System;
using System.Collections.Generic;

namespace Cambrain_Foodos.Models
{
    public partial class Restaurant
    {
        public int RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? Branch { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RestaurantImage { get;  set; }
    }
}
