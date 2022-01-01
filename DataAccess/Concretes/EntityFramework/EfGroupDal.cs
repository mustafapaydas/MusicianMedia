using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfGroupDal : EfEntityRepositoryBase<Group, MusicContext>,IGroupDal
    {
    }
}