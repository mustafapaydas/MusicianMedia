using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class InstrumentValidator:AbstractValidator<Instrument>
    {
        public InstrumentValidator()
        {
            RuleFor(instrument => instrument.InstrumentName).NotEmpty().WithMessage(Messages.MissingCharacter);
            RuleFor(instrumet => instrumet.InstrumentDescription).NotEmpty();
        }
    }
}
