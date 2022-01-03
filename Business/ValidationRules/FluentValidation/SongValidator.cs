using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Entities.Concretes;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class SongValidator:AbstractValidator<Song>
    {
        public SongValidator()
        {
            RuleFor(song => song.SongName).NotEmpty().WithMessage(Messages.MissingCharacter); 
            RuleFor(song => song.Lyrics).NotEmpty().When(song=>song.KindId == 5);
        }
    }
}
