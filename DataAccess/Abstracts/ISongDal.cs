using System.Collections.Generic;
using Core.DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;

namespace DataAccess.Abstracts
{
    public interface ISongDal : IEntityRepositoryBase<Song>
    {
        List<SongDetailDto> GetSongDetails();
    }
}