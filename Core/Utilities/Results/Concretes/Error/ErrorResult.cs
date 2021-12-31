using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concretes.Error
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(message, false)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
