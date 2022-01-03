using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSongDal : EfEntityRepositoryBase<Song, MusicContext>, ISongDal
    {
        public List<SongDetailDto> GetSongDetails()
        {
            using (var context=new MusicContext())
            {
                var result = from song in context.Songs join kind in context.Kinds on song.KindId equals kind.KindId
                    select new SongDetailDto
                    {
                        SongName = song.SongName,
                        KindName = kind.KindName,
                        Lyrics = song.Lyrics,
                        OfSinger = song.OfSinger
                    };
                return result.ToList();
            }
        }
    }
}
