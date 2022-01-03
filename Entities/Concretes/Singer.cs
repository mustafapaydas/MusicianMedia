using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Singer:IEntity
    {
        public int SingerId { get; set; }
        public string SingerName { get; set; }
    }
}
