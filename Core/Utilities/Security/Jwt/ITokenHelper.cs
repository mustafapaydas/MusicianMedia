using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concretes;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateAccessToken(User user,List<OperationClaim> claims);
    }
}
