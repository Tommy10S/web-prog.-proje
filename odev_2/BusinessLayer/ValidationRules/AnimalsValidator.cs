using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnimalsValidator:AbstractValidator<Animals>
    {
        public AnimalsValidator()
        {
            RuleFor(x => x.AnimalName).NotEmpty().WithMessage("Hayvan adını boş geçemezsiniz!");
            RuleFor(x => x.AnimalType).NotEmpty().WithMessage("Hayvan türünü boş geçemezsiniz!");
            RuleFor(x => x.AnimalName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.AnimalName).MaximumLength(30).WithMessage("Lütfen 30 karakterden fazla değer girişi yapmayınız!");
        }
    }
}
