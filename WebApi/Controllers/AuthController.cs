using BusinessLayer.Abstract;
using EntityLayer.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService _authService)
        {
            this.authService = _authService;
        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterAuthDto authDto)
        {
            authService.Register(authDto);
            return Ok("Kullanıcı başarı ile eklendi");
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginAuthDto login)
        {
            var result = authService.Login(login);
            return Ok(result);

        }
    }
}
