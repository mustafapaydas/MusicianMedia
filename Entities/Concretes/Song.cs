using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Song:IEntity
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public int KindId { get; set; }
    }
}
