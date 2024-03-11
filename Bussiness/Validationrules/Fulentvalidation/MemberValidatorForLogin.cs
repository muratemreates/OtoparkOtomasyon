using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Bussiness.Validationrules.Fulentvalidation
{
    public class MemberValidatorForLogin : AbstractValidator<Member>
    {
        public MemberValidatorForLogin()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty().WithMessage("Lütfen adınızı giriniz");
            RuleFor(u => u.Name).MinimumLength(3).WithMessage("İsim alanı 3 karakterden az olamaz");


            RuleFor(u => u.Surname).NotNull().NotEmpty().WithMessage("Lütfen soyadınızı giriniz");
            RuleFor(u => u.Surname).MinimumLength(2).WithMessage("İsim alanı 2 karakterden az olamaz");


            RuleFor(u => u.UserName).NotNull().NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz");

            RuleFor(u => u.Password).NotNull().NotEmpty().WithMessage("Lütfen şifrenizi giriniz");
            RuleFor(u => u.Password).MinimumLength(6).WithMessage("Şifreniz 6 karakterden az olamaz");


            RuleFor(u => u.Email).NotEmpty().NotNull().WithMessage("Lütfen email adresinizi giriniz");

            RuleFor(u => u.Gsm).NotNull().NotEmpty().WithMessage("Lütfen iletişim numaranızı giriniz").
                Must(gsm => !string.IsNullOrWhiteSpace(gsm)).WithMessage("İletişim numarasında boşluk olamaz"); ;

            RuleFor(u => u.Gsm).MinimumLength(14).WithMessage("İletişim numaranız en az 10 haneli olmalıdır");



        }
    }
}
