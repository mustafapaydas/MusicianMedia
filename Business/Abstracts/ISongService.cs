using System.Collections.Generic;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ISongService
    {
        IDataResult<List<Song>> GetAll();
        IResult Add(Song song);
        IResult Delete(Song song);
        IResult Update(Song song);
        IDataResult<Song> GetById(int songId);

    }
}