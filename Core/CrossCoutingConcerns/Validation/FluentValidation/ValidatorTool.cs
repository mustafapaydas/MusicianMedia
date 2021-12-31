using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Core.CrossCoutingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<Object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }
    }
}
