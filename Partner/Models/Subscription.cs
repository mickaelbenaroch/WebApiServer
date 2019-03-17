using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partner.Models
{
    public class Subscription
    {
        public string SubscriptionName { get; set; }

        public string SubscriptionNumber { get; set; }

        public Package[] PackageList { get; set; }
    }
}