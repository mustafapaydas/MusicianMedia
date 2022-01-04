using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Success;
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
            return new SuccessDataResult<List<Singer>>(_singerDal.GetAll());
        }

        public IResult Add(Singer singer)
        {
            _singerDal.Add(singer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Singer singer)
        {
            _singerDal.Delete(singer);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Singer singer)
        {
            _singerDal.Update(singer);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Singer> GetById(int singerId)
        {
            return new SuccessDataResult<Singer>(_singerDal.Get(singer => singer.SingerId == singerId));
        }
    }
}
