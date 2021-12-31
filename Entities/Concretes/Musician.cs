using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Musician:IEntity 
    {
        public int MusicianId { get; set; }
        public int UserId { get; set; }
        public int InstrumentId { get; set; }
        public string WorkFor { get; set; }
    }
}
