using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SupermercadoApi.Data.Repositories;
using SupermercadoApi.Dtos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SupermercadoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController: ControllerBase
    {
        private readonly IAuthRepository _repository;
        public AuthController(IAuthRepository authRepository)
        {
            _repository = authRepository;;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repository.Login(userForLoginDto.Username, userForLoginDto.Password);
            if (userFromRepo == null) return Unauthorized();
            return Ok(userFromRepo);
        }
    }
}
