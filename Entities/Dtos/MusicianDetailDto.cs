using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Dtos
{
    public class MusicianDetailDto:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string WorkFor { get; set; }
        public string InstrumentName { get; set; }

    }
}
