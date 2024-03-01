using Entities.Concrete;
using FluentValidation;

namespace Bussiness.Validationrules.Fulentvalidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Surname).NotEmpty();
            RuleFor(p => p.CitizenshipNumber).NotEmpty();
            RuleFor(p => p.CarBrand).NotEmpty();
            RuleFor(p => p.NumberPlate).NotEmpty();
            RuleFor(p => p.Gsm).NotEmpty();
            RuleFor(p => p.CarPark).NotEmpty();
            
        }
    }
}
