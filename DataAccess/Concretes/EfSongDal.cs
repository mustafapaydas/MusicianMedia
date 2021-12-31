using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfSongDal : EfEntityRepositoryBase<Song, MusicContext>,ISongDal
    {
    }
}