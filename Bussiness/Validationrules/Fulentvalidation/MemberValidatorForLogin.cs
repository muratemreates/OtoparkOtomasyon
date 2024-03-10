using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Bussiness.Validationrules.Fulentvalidation
{
    public class MemberValidatorForLogin:AbstractValidator<Member>
    {
        public MemberValidatorForLogin()
        {
            RuleFor(u => u.UserName).NotNull().NotEmpty().WithMessage("Lütfen kullanıcı adınızı giriniz");
            RuleFor(u => u.Password).NotNull().NotEmpty().WithMessage("Lütfen şifrenizi giriniz");
        }
    }
}
