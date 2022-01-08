using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.Concretes;
using Core.Entities.Concretes;
using DataAccess.Abstracts;

namespace DataAccess.Concretes.EntityFramework
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
                             where userOperationClaim.UserId == user.UserId
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
