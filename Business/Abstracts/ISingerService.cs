using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ISingerService
    {
        IDataResult<List<Singer>> GetAll();
        IResult Add(Singer singer);
        IResult Delete(Singer singer);
        IResult Update(Singer singer);
        IDataResult<Singer> GetById(int singerId);
    }
}
