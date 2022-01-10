using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IMusicKindService
    {
        IResult Add(MusicKind kind);
        IResult Delete(MusicKind kind);
        IDataResult<MusicKind> GetById(int kindId);
        IDataResult<List<MusicKind>> GetAll();
    }
}
