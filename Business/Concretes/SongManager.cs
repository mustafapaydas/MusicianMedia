using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Business.Abstracts;
using Business.Aspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Error;
using Core.Utilities.Results.Concretes.Success;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;


namespace Business.Concretes
{
    public class SongManager:ISongService
    {
        private ISongDal _songDal;
        private ISingerService _singerService;

        public SongManager(ISongDal songDal,ISingerService singerService)
        {
            _songDal = songDal;
            _singerService = singerService;
        }

        public IDataResult<List<Song>> GetAll()
        {
            return new SuccessDataResult<List<Song>>(_songDal.GetAll());
        }
        [ValidationAspect(typeof(SongValidator))]
        [SecuredOperation("admin,musician,group")]
        public IResult Add(Song song)
        {
            IResult result=BusinessRules.Run(CheckIfSongCountOfKindCorrect(song.KindId),
                CheckIfSingerSongNameAlreadyExists(song),CheckIfSingerExists(song));
            if (result!=null)
            {
                return result;
            }
            _songDal.Add(song);
            return new SuccessResult(Messages.Added);
        }
        [SecuredOperation("admin,musician,group")]
        public IResult Delete(Song song)
        {
            _songDal.Delete(song);
            return new SuccessResult(Messages.Deleted);
        }

        [ValidationAspect(typeof(SongValidator))]
        [SecuredOperation("admin,musician,group")]
        public IResult Update(Song song)
        {
            IResult result=BusinessRules.Run(CheckIfSongCountOfKindCorrect(song.KindId), 
                CheckIfSingerSongNameAlreadyExists(song),CheckIfSingerExists(song));
            if (result != null)
            {
                return result;
            }
            _songDal.Update(song);
            return new SuccessResult(Messages.Updated);
        }
        
        public IDataResult<Song> GetById(int songId)
        {
            return new SuccessDataResult<Song>(_songDal.Get(song => song.SongId == songId));
        }

        /*public IDataResult<List<SongDetailDto>> AllOfDetail()
        {
            return new SuccessDataResult<List<SongDetailDto>>(_songDal.GetSongDetails());
        }
        */
        public IDataResult<List<Song>> GetBySinger(int singerId)
        {
            return new SuccessDataResult<List<Song>>(_songDal.GetAll(song => song.SingerId == singerId));
        }

       


        private IResult CheckIfSongCountOfKindCorrect(int kindId)
        {
            var count = _songDal.GetAll(song => song.KindId == kindId).Count;
            if (count>100)
            {
                return new ErrorResult(Messages.Full);
            }

            return new SuccessResult();
        }

        private IResult CheckIfSingerAndSongLimitExceded(Song song)
        {
            var songsCountOfSinger = _songDal.GetAll(sing => sing.SingerId == song.SingerId).Count;
            
            if (songsCountOfSinger >=20)
            {
                return new ErrorResult(Messages.LimitedExceded);
            }

            return new SuccessResult();
        }

        private IResult CheckIfSingerSongNameAlreadyExists(Song song)
        {
            var songs = _songDal.GetAll(sing => sing.SingerId == song.SingerId);
            foreach (var sing in songs)
            {
                if (sing.SongName==song.SongName)
                {
                    return new ErrorResult(Messages.SongNameAlreadyExists);
                }
            }

            return new SuccessResult();
        }

        private IResult CheckIfSingerExists(Song song)
        {
            var check = _singerService.GetById(song.SingerId);
            if (check==null)
            {
                return new ErrorResult(Messages.NotFoundSinger);
            }

            return new SuccessResult();
        }
    }
}
