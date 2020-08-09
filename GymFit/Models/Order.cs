using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public Collection<OrderDetails> orderDetails { get; set; } = new Collection<OrderDetails>();

    }
}
