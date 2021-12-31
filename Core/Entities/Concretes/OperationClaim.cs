using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstracts;

namespace Core.Entities.Concretes
{
    public class OperationClaim:IEntity
    {
        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }
    }
}
