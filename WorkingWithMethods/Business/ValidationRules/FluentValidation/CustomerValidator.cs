using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().When(c => c.IdentityNumber == "123").WithMessage("Adı Boş Olamaz");
            RuleFor(c => c.FirstName).NotEmpty().When(c => c.IdentityNumber == "1234").WithMessage("Adı Boş Olamaz");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("soyadı Boş Olamaz");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("Tc Kimlik Numarası Boş Olamaz");
            RuleFor(c => c.IdentityNumber).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
}
