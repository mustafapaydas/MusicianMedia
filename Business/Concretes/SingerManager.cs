using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class SingerManager:ISingerService
    {
        private ISingerDal _singerDal;

        public SingerManager(ISingerDal singerDal)
        {
            _singerDal = singerDal;
        }

        public IDataResult<List<Singer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Singer singer)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Singer singer)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Singer singer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Singer> GetById(int singerId)
        {
            throw new NotImplementedException();
        }
    }
}
