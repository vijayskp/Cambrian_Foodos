using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cambrain_Foodos.Models
{
    public partial class order_details
    {
        [Key]
        public int RecordId { get; set; }
        public string? ItemName { get; set; }
        public int? ItemPrice { get; set; }
        public int? Quantity { get; set; }
      
    }
}
