using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Bussiness.Validationrules.Fulentvalidation
{
    public class CarBakValidatorForAdd:AbstractValidator<CarBak>
    {
        public CarBakValidatorForAdd()
        {
            RuleFor(p => p.Name).NotNull().NotEmpty().WithMessage("İsim boş bırakılamaz");
            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyisim boş bırakılamaz");
            RuleFor(p => p.CitizenshipNumber).NotEmpty().WithMessage("Vatandaşlık nuamrası boş bırakılamaz");
            RuleFor(p => p.CarBrand).NotEmpty().WithMessage("Araç markası boş bıraklılamaz");
            RuleFor(p => p.NumberPlate).NotEmpty().WithMessage("Araç plakası boş bırakılamaz");
            RuleFor(p => p.Gsm).NotEmpty().WithMessage("İletişim numarası boşi bırakılamaz");
            RuleFor(p => p.CarPark).NotEmpty().WithMessage("Park yeri seçilmeli");
        }
    }
}
