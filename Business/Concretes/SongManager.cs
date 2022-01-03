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
    public class SongManager:ISongService
    {
        private ISongDal _songDal;

        public SongManager(ISongDal songDal)
        {
            _songDal = songDal;
        }

        public IDataResult<List<Song>> GetAll()
        {
            return new SuccessDataResult<List<Song>>(_songDal.GetAll());
        }
        [ValidationAspect(typeof(SongValidator))]
        public IResult Add(Song song)
        {
            _songDal.Add(song);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Song song)
        {
            _songDal.Delete(song);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Song song)
        {
            _songDal.Update(song);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Song> GetById(int songId)
        {
            return new SuccessDataResult<Song>(_songDal.Get(song => song.SongId == songId));
        }

        public IDataResult<List<SongDetailDto>> AllOfDetail()
        {
            return new SuccessDataResult<List<SongDetailDto>>(_songDal.GetSongDetails());
        }
    }
}
