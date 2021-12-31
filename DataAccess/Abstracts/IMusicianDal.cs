using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;

namespace DataAccess.Abstracts
{
    public interface IMusicianDal:IEntityRepositoryBase<Musician>
    {
        List<MusicianDetailDto> GetallMusician();
    }
}
