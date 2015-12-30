using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomersOrders.Models
{
    public class CustomerDetailsDto
    {
        public string FName { get; set; }

        public string LName { get; set; }

        public bool Freqshopcard { get; set; }

        public byte Age { get; set; }

        public List<Order> Orders { get; set; }
    }
}