using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using FluentValidation;

namespace Business.Concrete
{
    public class CustomerManager
    {
        ICustomerDal _customerDal;
        IPersonService _personService;
        public CustomerManager(ICustomerDal customerDal, IPersonService personService)
        {
            _customerDal = customerDal;
            _personService = personService;
        }
        //Müşteri ekleme
        public void Add(Customer customer)
        {
            //ValidateFirstNameIfEmpty(customer);
            //ValidateLastNameIfEmpty(customer);
            //ValidateIdentityNumberIfEmpty(customer);
            Utility.Validate(new CustomerValidator(), (IValidationContext)customer);
            //Mernins sistemini kullanrak kişi bilgilerini doğrulama
            CheckPersonExists(customer);
            //Müşterinin veritabanında var olup olmadığını kontrol etme
            CheckCustomerExists(customer);
            _customerDal.Add(customer);
        }
        public void AddByOhterBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLength(customer);
            CheckCustomerExists(customer);
            _customerDal.Add(customer);
        }
        private void CheckPersonExists(Person person)
        {
            if (!_personService.CheckPerson(person))
            {
                throw new Exception("Kişi Bilgileri Hatalı...");
            }
        }
        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (!String.IsNullOrEmpty(customer.FirstName)) throw new Exception("Validasyon hatası oldu");
        }
        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (!String.IsNullOrEmpty(customer.LastName)) throw new Exception("Validasyon hatası oldu");
        }
        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (!String.IsNullOrEmpty(customer.IdentityNumber)) throw new Exception("Validasyon hatası oldu");
        }
        private void ValidateFirstNameLength(Customer customer)
        {
            if (customer.FirstName.Length < 2) throw new Exception("Validasyon hatası oldu");
        }
        private void CheckCustomerExists(Customer customer)
        {
            if (_customerDal.CustomerExists(customer)) throw new Exception("Müşteri zaten mevcut");
        }
    }
}
