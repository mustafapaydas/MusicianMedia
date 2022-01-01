using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Entities.Concretes
{
    public class Image : IEntity
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
    }
}