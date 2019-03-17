using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partner.Models
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string IdentityNumber { get; set; }

        public Subscription[] Subscriptions { get; set; }
    }
}