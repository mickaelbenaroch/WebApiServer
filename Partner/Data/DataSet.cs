using Partner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partner.Data
{
    public class DataSet
    {
        public Customer[] customers = new Customer[2] { customer1, customer2 };


        public static Package package1 = new Package()
        {
            PackageID = Enums.PackageEnum.CALLS,
            PackageName = "MyPackage1",
            Quantity = 100,
            Usage = 50
        };

        public static Package package2 = new Package()
        {
            PackageID = Enums.PackageEnum.SMS,
            PackageName = "MyPackage2",
            Quantity = 100,
            Usage = 25
        };

        public static Package package3 = new Package()
        {
            PackageID = Enums.PackageEnum.SURFING,
            PackageName = "MyPackage3",
            Quantity = 100,
            Usage = 10
        };

        public static Subscription subscription1 = new Subscription()
        {
            SubscriptionName = "MySunscription1",
            SubscriptionNumber = "001",
            PackageList = new Package[2] { package1, package2 }
        };

        public static Subscription subscription2 = new Subscription()
        {
            SubscriptionName = "MySunscription2",
            SubscriptionNumber = "002",
            PackageList = new Package[2] { package2, package3 }
        };

        public static Subscription subscription3 = new Subscription()
        {
            SubscriptionName = "MySunscription3",
            SubscriptionNumber = "003",
            PackageList = new Package[2] { package1, package3 }
        };


        public static Customer customer1 = new Customer()
        {
            FirstName = "Mickael",
            LastName = "Benaroch",
            Address = "המרגנית 4 רמת גן",
            IdentityNumber = "328782800",
            Subscriptions = new Subscription[2] { subscription1, subscription2 }
        };

        public static Customer customer2 = new Customer()
        {
            FirstName = "Yoni",
            LastName = "Israel",
            Address = "רוקח 4 רמת גן",
            IdentityNumber = "247576766",
            Subscriptions = new Subscription[2] { subscription2, subscription3 }
        };
    }
}