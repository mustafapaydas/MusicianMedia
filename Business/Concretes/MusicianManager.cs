using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Success;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;

namespace Business.Concretes
{
    
    public class MusicianManager:IMusicianService
    {
        private IMusicianDal _musicianDal;

        public MusicianManager(IMusicianDal musicianDal)
        {
            _musicianDal = musicianDal;
        }
        //[ValidationAspect(typeof(MusicianValidator))]
        public IResult Add(Musician musician)
        {
            _musicianDal.Add(musician);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Musician musician)
        {
            _musicianDal.Delete(musician);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<MusicianDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<MusicianDetailDto>>(_musicianDal.GetallMusician());
        }

        public IDataResult<Musician> GetById(int musicianId)
        {
            return new SuccessDataResult<Musician>(_musicianDal.Get(musician => musician.MusicianId == musicianId),Messages.Get);
        }

        public IResult Update(Musician musician)
        {
            _musicianDal.Update(musician);
            return new SuccessResult(Messages.Updated);
        }
    }
}
