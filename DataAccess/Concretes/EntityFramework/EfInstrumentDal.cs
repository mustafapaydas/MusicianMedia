using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfInstrumentDal:EfEntityRepositoryBase<Instrument,MusicContext>,IInstrumentDal
    {
    }
}
