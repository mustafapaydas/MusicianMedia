using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Entities.Concretes;
using Core.Utilities.Hashing;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Error;
using Core.Utilities.Results.Concretes.Success;
using Core.Utilities.Security.Jwt;
using Entities.Dtos;

namespace Business.Concretes
{
    public class AuthManager:IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService,ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper= tokenHelper;
        }
       // [ValidationAspect(typeof(UserValidation))]
        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordSalt, passwordHash;
            HashingHelper.CreatePasswordHash(password,out passwordSalt,out passwordHash);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                UserFirstName = userForRegisterDto.FirstName,
                UserLastName = userForRegisterDto.LastName,
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash,
                Status = true
            };
           _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email).Data;
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.NotFoundUser);
            }

            var passwordHash = HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PasswordSalt,userToCheck.PasswordHash);
            if (!passwordHash)
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email)!=null)
            {
                return new SuccessResult(Messages.UserAlreadyExists);
            }

            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateAccessToken(user, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.TokenCreated);
        }

        
    }
}
