using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Results.Concretes
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public DataResult(T data,string message, bool success) : base(message, success)
        {
            Data= data;
        }

        public DataResult(T data,bool success) : base(success)
        {
            Data=data;
        }

        
        public T Data { get; }
    }
}
