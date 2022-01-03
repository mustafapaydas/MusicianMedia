using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class InstrumentValidator:AbstractValidator<Instrument>
    {
        public InstrumentValidator()
        {
            RuleFor(instrument => instrument.InstrumentName).MinimumLength(7).WithMessage("Hatalısın");
        }
    }
}
