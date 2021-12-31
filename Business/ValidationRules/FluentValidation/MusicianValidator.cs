using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MusicianValidator:AbstractValidator<Musician>
    {
        public MusicianValidator()
        {
            RuleFor(musician => musician.InstrumentId).NotEmpty();
        }
    }
}
