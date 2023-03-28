using Business.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ServiceAdapter
{
    public class KpsService
    {
        public bool CheckPerson(string identityNumber, string name, string surname, int year)
        {
            return true;
        }
    }
    public class KpsServiceAdapter : IPersonService
    {
        public bool CheckPerson(Person person)
        {
            KpsService kpsService = new KpsService();
            return kpsService.CheckPerson(person.IdentityNumber, person.FirstName, person.LastName, person.YearOfBirth);
        }
    }

}
