using Business.Concrete;
using Business.ServiceAdapter;
using Business.Utilities;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = NinjectInstanceFactory.GetInstance<CustomerManager>();
            customerManager.Add(new Customer { FirstName = "Barış", LastName = "KURT", IdentityNumber = "1" });
            customerManager.Add(new Customer { FirstName = "Güldane", LastName = "AKSU KURT", IdentityNumber = "2", CityId = 46 });
            customerManager.Add(new Customer { FirstName = "Defne", LastName = "KURT", IdentityNumber = "3" });
            customerManager.Add(new Customer { FirstName = "Deniz", LastName = "KURT", IdentityNumber = "4" });
        }
    }
    
    
    
    
   
    

    
}
