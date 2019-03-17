using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partner.Models
{
    public class AuthModel
    {
        public bool DoesExist { get; set; }

        public string Token { get; set; }

        public string Message { get; set; }

        public Customer customer { get; set; }
    }
}