using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IDataResult<User> GetByMail(string email);
    }
}
