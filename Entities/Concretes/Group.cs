using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Group:IEntity
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Soloist { get; set; }
    }
}
