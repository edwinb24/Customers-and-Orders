using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomersOrders.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        public double Amount { get; set; }

        public string Date { get; set; }

        //Navigation Property
        public Customer Customer { get; set; }
    }
}