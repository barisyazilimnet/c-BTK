using Business.Abstract;
using Business.Concrete;
using Business.ServiceAdapter;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerDal>().To<EfCustomerDal>();
            Bind<CustomerManager>().To<CustomerManager>();
            Bind<IPersonService>().To<KpsServiceAdapter>();
        }
    }
}
