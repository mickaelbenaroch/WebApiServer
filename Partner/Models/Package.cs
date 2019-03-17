using Partner.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partner.Models
{
    public class Package
    {
        public PackageEnum PackageID  { get; set; }

        public int Usage { get; set; }

        public int Quantity { get; set; }

        public string PackageName { get; set; }
    }
}