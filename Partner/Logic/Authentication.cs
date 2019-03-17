using Partner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partner.Logic
{
    public class Authentication
    {
        public AuthModel Authenticate(string id)
        {
            AuthModel authModel = new AuthModel();

            Data.DataSet dataSet = new Data.DataSet();

            List<Customer> customer = dataSet.customers.Where(c => c.IdentityNumber == id).ToList();

            if (customer.Count == 0 || customer == null)
            {
                authModel.customer = null;
                authModel.DoesExist = false;
                authModel.Message = "User doesnt exist";
                authModel.Token = null;
            }
            else if (customer.Count > 1)
            {
                authModel.customer = null;
                authModel.DoesExist = false;
                authModel.Message = "there is more than one customer with this id" + id;
                authModel.Token = null;
            }
            else
            {
                authModel.customer = customer.ElementAt(0);
                authModel.DoesExist = true;
                authModel.Message = "valid";
                authModel.Token = Guid.NewGuid().ToString(); 
            }

            return authModel;
        }
    }
}