using Entities.Concrete;
using FluentValidation;

namespace Bussiness.Validationrules.Fulentvalidation
{
    public class CarValidatorForAdd:AbstractValidator<Car>
    {
        public CarValidatorForAdd()
        {
            //isim kuralları
            RuleFor(p => p.Name).NotNull().NotEmpty().WithMessage("İsim boş bırakılamaz");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("İsim en az 3 harften oluşmalıdır");

            //soyisim kuralları
            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyisim boş bırakılamaz");
            RuleFor(p => p.Surname).MinimumLength(2).WithMessage("Soyisim en az 2 harften oluşmalıdır");


            RuleFor(p => p.CarBrand).NotEmpty().WithMessage("Araç markası boş bıraklılamaz");
            RuleFor(p => p.NumberPlate).NotEmpty().WithMessage("Araç plakası boş bırakılamaz");
            RuleFor(p => p.CarPark).NotEmpty().WithMessage("Park yeri seçilmeli");


            //Vatandaşlık Numarası Kuralları
            RuleFor(p => p.CitizenshipNumber).NotEmpty().WithMessage("Vatandaşlık nuamrası boş bırakılamaz");
            RuleFor(p => p.CitizenshipNumber).MinimumLength(11).WithMessage("Tc en az 11 karakter olmalıdır.");

            //GSM Kulları
            RuleFor(p => p.Gsm).NotEmpty().WithMessage("İletişim numarası boşi bırakılamaz");
           // RuleFor(p => p.Gsm).Matches(@"^05\d{9}$").WithMessage("Telefon numarasını doğru formatta giriniz");
            RuleFor(p => p.Gsm).MinimumLength(10).WithMessage("İletişim numarası en az 10 haneli girilmelidir.");
        }
    }
}
