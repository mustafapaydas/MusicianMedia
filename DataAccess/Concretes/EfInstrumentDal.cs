using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfInstrumentDal:EfEntityRepositoryBase<Instrument,MusicContext>,IInstrumentDal
    {
    }
}
