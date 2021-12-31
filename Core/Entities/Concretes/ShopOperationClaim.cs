using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Core.Entities.Concretes
{
    public class ShopOperationClaim:IEntity
    {
        public int mId { get; set; }
        public int ShopId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
