using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.Dtos;

namespace DataAccess.Concretes
{
    public class EfMusicianDal:EfEntityRepositoryBase<Musician,MusicContext>,IMusicianDal
    {
        public List<MusicianDetailDto> GetallMusician()
        {
            using (var context=new MusicContext())
            {
                var query = from musician in context.Musicians
                    join user in context.Users on musician.UserId equals user.UserId
                    join instrument in context.Instruments on musician.InstrumentId equals instrument.InstrumentId
                    select new MusicianDetailDto
                    {
                        FirstName = user.UserFirstName,
                        LastName = user.UserLastName,
                        InstrumentName = instrument.InstrumentName,
                        WorkFor = musician.WorkFor,
                        Email = user.Email
                    };
                return query.ToList();
            }
        }
     
    }
}
