using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cambrain_Foodos.Models
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get;  set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }
    }
}
