using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities
{
    public static class Utility
    {
        /// <summary>
        /// Nesneyi validator kullanarak doğrulama
        /// </summary>
        /// <param name="validator">Kullanılacak olan validator</param>
        /// <param name="entity">Doğrulanacak olan nesne</param>
        /// <exception cref="ValidationException"></exception>
        public static void Validate(IValidator validator, IValidationContext entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
