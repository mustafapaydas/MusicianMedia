using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FluentValidation;

namespace Core.CrossCoutingConcerns.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,Object entity)
        {
            var context = new ValidationContext<Object>(entity);
            var result = validator.Validate(context);
            
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors.ToString());
            }
        }
    }
}
