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
    public class InstrumentManager:IInstrumentService
    {
        private IInstrumentDal _instrumentDal;

        public InstrumentManager(IInstrumentDal instrumentDal)
        {
            _instrumentDal = instrumentDal;
        }

        public IDataResult<List<Instrument>> GetAll()
        {
            return new SuccessDataResult<List<Instrument>>(_instrumentDal.GetAll());
        }

        public IResult Add(Instrument instrument)
        {
           _instrumentDal.Add(instrument);
           return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Instrument instrument)
        {
            _instrumentDal.Delete(instrument);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Instrument instrument)
        {
            _instrumentDal.Update(instrument);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<Instrument> GetById(int instrumentId)
        {
            return new SuccessDataResult<Instrument>(_instrumentDal.Get(instrument =>
                instrument.InstrumentId == instrumentId));
        }
    }
}
