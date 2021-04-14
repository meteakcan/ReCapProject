using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(1990).WithMessage("Bu tarihten daha eski bir araba ekleyemezsiniz.");
            RuleFor(c => c.ModelYear).LessThanOrEqualTo(2022).WithMessage("Bu tarihten daha yeni bir araba ekleyemezsiniz.");


            RuleFor(c => c.Price).GreaterThanOrEqualTo(50).WithMessage("Günlük kirası 50 liradan az araba ekleyemezsiniz.");

            RuleFor(c => c.Price).GreaterThanOrEqualTo(100).When(c => c.ModelYear == 2022);

            RuleFor(c => c.Description).MaximumLength(500).WithMessage("Açıklamaya 500 karakterden fazla mesaj yazılamaz.");
        }
    }
}
