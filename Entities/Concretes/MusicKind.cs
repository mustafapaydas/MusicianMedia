using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class MusicKind:IEntity
    {
        [Key]
        public int KindId { get; set; }
        public string KindName { get; set; }
    }
}
