using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MembersValidator : AbstractValidator<Member>
    {
        public MembersValidator()
        {
            RuleFor(x => x.memberName).NotEmpty().WithMessage("adı boş geçemezsiniz!");
            RuleFor(x => x.memberSurName).NotEmpty().WithMessage("soyadı boş geçemezsiniz!");
            RuleFor(x => x.memberEmail).NotEmpty().WithMessage("emaili boş geçmeyiniz!");
            RuleFor(x => x.memberPassword).MaximumLength(30).WithMessage("Lütfen 30 karakterden fazla değer girişi yapmayınız!");
        }
    }
}
