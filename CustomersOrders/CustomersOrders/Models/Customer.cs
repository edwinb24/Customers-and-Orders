using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomersOrders.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LName { get; set; }

        public bool Freqshopcard { get; set; }

        public byte Age { get; set; }

        //Navigation Property
        public ICollection<Order> Orders { get; set; }
    }
}