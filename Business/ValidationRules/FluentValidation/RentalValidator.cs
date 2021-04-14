using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).Must(RentDateRule).WithMessage("Kiralanma tarihi boş geçilemez.");
        }

        private bool RentDateRule(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
