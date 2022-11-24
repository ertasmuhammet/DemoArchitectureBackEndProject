using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet("getList")]
        public IActionResult GetList()
        {
            return Ok(userService.GetList());
        }

    }
}
