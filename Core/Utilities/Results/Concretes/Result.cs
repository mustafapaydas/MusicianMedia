using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Results.Concretes
{
    public class Result:IResult
    {
        public bool Success { get; }
        public string Message { get; }

        public Result(string message,bool success):this(success)
        {
            Message=message;
        }

        public Result(bool success)
        {
            Success=success;
        }
    }
}
