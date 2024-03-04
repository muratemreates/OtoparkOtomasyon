using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Bussiness.Validationrules.Fulentvalidation
{
    public class CarValidatorForDelete:AbstractValidator<Car>
    {
        public CarValidatorForDelete()
        {
            RuleFor(p => p.Id).NotNull().WithMessage("Lütfen listeden araba seçimi yapınız");
        }
    }
}
