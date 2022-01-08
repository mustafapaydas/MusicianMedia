using Business.Abstracts;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private IAuthService _authService;

        public AuthsController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]

        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var login = _authService.Login(userForLoginDto);
            if (!login.Success)
            {
                return BadRequest(login.Message);
            }

            var token= _authService.CreateAccessToken(login.Data);
            if (token.Success)
            {
                return Ok(token.Data);
            }

            return BadRequest(token.Message);
        }
       


        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists);
            }

            var register = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(register.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
