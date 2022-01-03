using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class MusicKind:IEntity
    {
        public int KindId { get; set; }
        public string KindName { get; set; } 
    }
}
