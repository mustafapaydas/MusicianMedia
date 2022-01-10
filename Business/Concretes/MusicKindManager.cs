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
    public class MusicKindManager : IMusicKindService
    {
        private IMusicKindDal _musicKindDal;

        public MusicKindManager(IMusicKindDal musicKindDal)
        {
            _musicKindDal = musicKindDal;
        }

        public IResult Add(MusicKind kind)
        {
            _musicKindDal.Add(kind);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(MusicKind kind)
        {
            _musicKindDal.Delete(kind);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<MusicKind>> GetAll()
        {
            return new SuccessDataResult<List<MusicKind>>(_musicKindDal.GetAll());
        }

        public IDataResult<MusicKind> GetById(int kindId)
        {
            return new SuccessDataResult<MusicKind>(_musicKindDal.Get(kind => kind.KindId == kindId));
        }
    }
}
