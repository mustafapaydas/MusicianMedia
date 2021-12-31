using System.Collections.Generic;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IInstrumentService
    {
        IDataResult<List<Instrument>> GetAll();
        IResult Add(Instrument instrument);
        IResult Delete(Instrument instrument);
        IResult Update(Instrument instrument);
        IDataResult<Instrument> GetById(int instrumentId);

    }
}