using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Dtos
{
    public class SongDetailDto:IDto
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string KindName { get; set; }
        public string Lyrics { get; set; }
        public string SingerName { get; set; }
    }
}
