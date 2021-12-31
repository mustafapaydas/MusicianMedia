using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.Abstracts;
using Core.DataAccess.Concretes;
using Core.Entities.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

namespace DataAccess.Concretes
{
    public class EfUserDal : EfEntityRepositoryBase<User, MusicContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context=new MusicContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                    select new OperationClaim
                    {
                        OperationClaimId = operationClaim.OperationClaimId,
                        OperationClaimName = operationClaim.OperationClaimName
                    };
                return result.ToList();
            } 
        }
    }
}
