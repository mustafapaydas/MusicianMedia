using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Business.Constants;
using Core.Entities.Concretes;
using Entities.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation:AbstractValidator<UserForRegisterDto>
    {
        
        public UserValidation()
        {
            RuleFor(user => user.FirstName).NotEmpty().MinimumLength(2).WithMessage(Messages.MissingCharacter);
            RuleFor(user => user.LastName).NotEmpty().MinimumLength(2).WithMessage(Messages.MissingCharacter);
            RuleFor(user => user.Email).NotEmpty().EmailAddress().WithMessage(Messages.NotEmail);
            RuleFor(user => user.Password).MinimumLength(8).WithMessage(Messages.MissingCharacter);
            RuleFor(user => user.Password).Must(InCapitalLetter).WithMessage(Messages.NotFoundCapitalLetter);
        }

        private bool InCapitalLetter(string arg)
        {
            var regex = new Regex(@"[A-Z]");
            if (!regex.IsMatch(arg))
            {
                return false;
            }
            return true;
        }
    }
}
