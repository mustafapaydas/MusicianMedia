using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos;

namespace Business.Abstracts
{
    public interface IMusicianService
    {
        IDataResult<List<MusicianDetailDto>> GetAll();
        IResult Add(Musician musician);
        IResult Delete(Musician musician);
        IResult Update(Musician musician);
        IDataResult<Musician> GetById(int musicianId);

    }
}
