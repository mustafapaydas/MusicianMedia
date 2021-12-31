using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Instrument:IEntity
    {
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentDescription { get; set; }
    }
}


