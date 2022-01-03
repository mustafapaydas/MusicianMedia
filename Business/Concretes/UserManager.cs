using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstracts;
using Business.Constants;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Success;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user),Messages.Listed);
        }

       
        public IResult Add(User user)
        {
           
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(user => user.Email == email));
        }
    }
}
